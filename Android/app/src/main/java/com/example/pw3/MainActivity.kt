package com.example.pw3

import android.content.Intent
import android.os.Bundle
import android.view.View
import android.widget.TextView
import android.widget.Toast
import kotlin.jvm.java
import androidx.appcompat.app.AppCompatActivity


class MainActivity : AppCompatActivity() {

private lateinit var textView: TextView

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)  // ← ЭТО ГЛАВНОЕ!

        textView = findViewById(R.id.textView)
    }

    fun toastMe(view: View) {
        Toast.makeText(this, "Hello Toast!", Toast.LENGTH_SHORT).show()
    }

    fun countMe(view: View) {
        val countString = textView.text.toString()
        var count = countString.toInt()
        count++
        textView.text = count.toString()
    }

    fun removeMe(view: View) {
        val countString = textView.text.toString()
        var count = countString.toInt()
        count--
        textView.text = count.toString()
    }

    fun randomMe(view: View) {
        val count = textView.text.toString().toInt()
        val intent = Intent(this, SecondActivity::class.java)
        intent.putExtra(SecondActivity.TOTAL_COUNT, count)
        startActivity(intent)
    }

    fun mediaMe(view: View) {
        val intent = Intent(this, MediaActivity::class.java)
        startActivity(intent)
    }
}
