package com.example.pw3

import android.media.MediaPlayer
import android.os.Bundle
import android.os.Handler
import android.widget.Button
import android.widget.SeekBar
import android.widget.TextView
import android.widget.Toast
import androidx.appcompat.app.AppCompatActivity
import java.util.concurrent.TimeUnit

class MediaActivity : AppCompatActivity() {

    private lateinit var mediaPlayer: MediaPlayer
    private lateinit var runnable: Runnable
    private var handler: Handler = Handler()
    private var pause: Boolean = false

    private lateinit var playBtn: Button
    private lateinit var pauseBtn: Button
    private lateinit var stopBtn: Button
    private lateinit var seekBar: SeekBar
    private lateinit var tvCurrent: TextView
    private lateinit var tvDuration: TextView


    private var currentTrack = 0
    private val trackList = listOf(R.raw.audio, R.raw.dog)

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_media)

        playBtn = findViewById(R.id.playBtn)
        pauseBtn = findViewById(R.id.pauseBtn)
        stopBtn = findViewById(R.id.stopBtn)
        seekBar = findViewById(R.id.seek_bar)
        tvCurrent = findViewById(R.id.tv_current)
        tvDuration = findViewById(R.id.tv_duration)


        playBtn.setOnClickListener {
            if (pause) {
                mediaPlayer.seekTo(mediaPlayer.currentPosition)
                mediaPlayer.start()
                pause = false
                Toast.makeText(this, "media playing", Toast.LENGTH_SHORT).show()
            } else {
                mediaPlayer = MediaPlayer.create(applicationContext, trackList[currentTrack])
                mediaPlayer.start()
                Toast.makeText(this, "media playing", Toast.LENGTH_SHORT).show()


                val duration = mediaPlayer.duration
                tvDuration.text = convertMillisToTime(duration)
                seekBar.max = duration


                startProgressUpdate()
            }

            playBtn.isEnabled = false
            pauseBtn.isEnabled = true
            stopBtn.isEnabled = true

            mediaPlayer.setOnCompletionListener {
                playBtn.isEnabled = true
                pauseBtn.isEnabled = false
                stopBtn.isEnabled = false
                Toast.makeText(this, "end", Toast.LENGTH_SHORT).show()


                seekBar.progress = 0
                tvCurrent.text = "00:00"
                handler.removeCallbacks(runnable)
            }
        }


        pauseBtn.setOnClickListener {
            if (::mediaPlayer.isInitialized && mediaPlayer.isPlaying) {
                mediaPlayer.pause()
                pause = true
                playBtn.isEnabled = true
                pauseBtn.isEnabled = false
                stopBtn.isEnabled = true
                Toast.makeText(this, "media pause", Toast.LENGTH_SHORT).show()
                handler.removeCallbacks(runnable)
            }
        }


        stopBtn.setOnClickListener {
            if (::mediaPlayer.isInitialized && (mediaPlayer.isPlaying || pause)) {
                pause = false

                mediaPlayer.stop()
                mediaPlayer.reset()
                mediaPlayer.release()
                handler.removeCallbacks(runnable)

                seekBar.progress = 0
                tvCurrent.text = "00:00"

                playBtn.isEnabled = true
                pauseBtn.isEnabled = false
                stopBtn.isEnabled = false

                Toast.makeText(this, "media stop", Toast.LENGTH_SHORT).show()
            }
        }


        seekBar.setOnSeekBarChangeListener(object : SeekBar.OnSeekBarChangeListener {
            override fun onProgressChanged(seekBar: SeekBar?, progress: Int, fromUser: Boolean) {
                if (fromUser && ::mediaPlayer.isInitialized) {
                    mediaPlayer.seekTo(progress)
                    tvCurrent.text = convertMillisToTime(progress)
                }
            }
            override fun onStartTrackingTouch(seekBar: SeekBar?) {}
            override fun onStopTrackingTouch(seekBar: SeekBar?) {}
        })

        val btnPrev = findViewById<Button>(R.id.btn_prev)
        val btnNext = findViewById<Button>(R.id.btn_next)


        btnPrev.setOnClickListener {
            if (::mediaPlayer.isInitialized) {
                mediaPlayer.stop()
                mediaPlayer.reset()
                mediaPlayer.release()
                handler.removeCallbacks(runnable)
            }
            currentTrack = if (currentTrack - 1 < 0) trackList.size - 1 else currentTrack - 1

            // Автоматически запускаем новый трек
            mediaPlayer = MediaPlayer.create(applicationContext, trackList[currentTrack])
            mediaPlayer.start()

            // Обновляем UI
            val duration = mediaPlayer.duration
            tvDuration.text = convertMillisToTime(duration)
            seekBar.max = duration
            startProgressUpdate()

            playBtn.isEnabled = false
            pauseBtn.isEnabled = true
            stopBtn.isEnabled = true
        }

        btnNext.setOnClickListener {
            if (::mediaPlayer.isInitialized) {
                mediaPlayer.stop()
                mediaPlayer.reset()
                mediaPlayer.release()
                handler.removeCallbacks(runnable)
            }
            currentTrack = (currentTrack + 1) % trackList.size

            // Автоматически запускаем новый трек
            mediaPlayer = MediaPlayer.create(applicationContext, trackList[currentTrack])
            mediaPlayer.start()

            // Обновляем UI
            val duration = mediaPlayer.duration
            tvDuration.text = convertMillisToTime(duration)
            seekBar.max = duration
            startProgressUpdate()

            playBtn.isEnabled = false
            pauseBtn.isEnabled = true
            stopBtn.isEnabled = true
        }

    }

    private fun startProgressUpdate() {
        runnable = Runnable {
            if (::mediaPlayer.isInitialized && mediaPlayer.isPlaying) {
                val current = mediaPlayer.currentPosition
                seekBar.progress = current
                tvCurrent.text = convertMillisToTime(current)
                handler.postDelayed(runnable, 1000)
            }
        }
        handler.postDelayed(runnable, 1000)
    }

    private fun convertMillisToTime(millis: Int): String {
        val minutes = TimeUnit.MILLISECONDS.toMinutes(millis.toLong())
        val seconds = TimeUnit.MILLISECONDS.toSeconds(millis.toLong()) -
                TimeUnit.MINUTES.toSeconds(minutes)
        return String.format("%02d:%02d", minutes, seconds)
    }


}