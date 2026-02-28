 PassMark (R) BurnInTest (TM) V8.1
Copyright (C) 1999-2017 PassMark Software
All Rights Reserved
http://www.passmark.com 

Overview
========
Passmark's BurnInTest is a software tool that allows all
the major sub-systems of a computer to be simultaneously
tested for reliability and stability.
<For more details see the online help>


Installation
============
1) Uninstall any previous version of BurnInTest
2) Double click (or Open) the downloaded ".exe" file
3) Follow the prompts


UnInstallation
==============
Use the Windows control panel, Add / Remove Programs


Requirements
============
- Operating System: Windows XP SP3, Windows Vista, Windows 7, Windows 8,
  2003 Server, 2008 Server, 2008 R2 Server, 2012 Server, 2012 R2 Server,
  Windows 10 Technical preview (*)
- CPU: CPU support (e.g. SSE2) is required in order to run the CPU tests for 
  those specific instructions (e.g. SSE2).
- GPU: DirectX 9.0c or above software for 3D graphics, video and webcam tests 
  (plus working DirectX drivers for your video card). DirectX 11 support 
  required for the GPGPU tests with DirectCompute compatible GPU.
- RAM: 256MB 
- Disk space: 40MB of free hard disk space (plus free space for the Disk test).
- A printer to run the printer test, set-up as the default printer in Windows.
- A CD ROM + 1 Music CD or Data CD to run the CD test.
- A CD-RW to run the CD burn test.
- A DVD-RW or DVD+RW to run the DVD burn test. 
- A network connection and the TCP/IP networking software installed for the 
  Network Tests
Pro version only:
- A serial port loop back plug for the serial port test. 
- A parallel port loop back plug for the parallel port test. 
- A USB 2.0 port loop back plug for the USB 2.0 port test. 
- A USB 3.0 port loop back plug for the USB 3.0 port test. 
- A webcam is required for the webcam test. 
- A battery is required for the battery test. 
- A microphone is required for the microphone test. 
- A PassMark PCIe 2.0 loopback card for the PCIe test.
- PassMark KeyboardTest V2.2 1011 (or higher) for Plugin Keyboard testing. 
- PassMark MonitorTest V3.1 1000 (or higher) for Plugin Monitor testing. 

(*)Operating System compatibility notes:
- BurnInTest must be run with administrator privileges. It requires 
  elevated administrator privileges in Windows Vista (and later). 
- The Standard and Torture RAM tests are available on all operating systems. 
  The Address Windowing Extensions test mode is only available under operating 
  systems where you can lock memory pages into memory, such as Windows XP 
  Professional.
- The CD and DVD burn tests require Windows Vista (and later), IMAPI v2 patched 
  Windows XP or IMAPI v2 patched Windows 2003 Server.
- The Bluetooth test is available on Windows workstations, Windows XP SP3 and 
	later, Windows Vista, Windows 7 and Windows 8.
- The GPGPU test requires Windows 7 or later.
- To monitor and report WHEA errors (like corrected ECC memory errors), Windows 
  7/ Windows 2008 R2 or later is required. Also the system must support WHEA 
  logging of hardware events in the CPER (Common Platform Error Reports) format.
- Windows XP SP2 and earlier are not supported by BurnInTest version 8.0. 
  Use BurnInTest v6.0 for compatibility with Windows 2000 and Windows XP SP2 
  (and earlier).
  Use BurnInTest v5.2 for compatibility with Windows 98 and Windows ME.

Version History
===============
Here is a summary of all changes that have been made in each version of 
BurnInTest.

Release 8.1 build 1025 - 21 December 2017
- Fixed a crash that could occur when launching from the command line and connecting to the management console (on test finish)
- Fixed a bug where incorrect available memory values could be displayed on some 64bit systems

Release 8.1 build 1024 - 11 August 2017
 - Changed PassMark web links from HTTP to HTTPS
 - Updated system information library with some changes;
    Added temperature offsets for Ryzen ThreadRipper chipsets
    Added support for obtaining CPU info for Skylake-X chipset
    Fixed bug with measuring base/turbo speeds
    Fixed a bug where temperature average was not calculated for systems with multiple CPUs

Release 8.1 build 1023 - 20 July 2017
 - Fixed a logging bug where errors logged against physical disks with numbers > 9 would not show both digits in the log message
 - Fixed a possible crash in during close/cleanup when the management console was enabled
 - Fixed a problem with management console preferences not allowing https addresses to be entered
 - Fixed a display bug where the drive letter displayed in the HTML logs could not match the display
 - Fixed an issue when reading system information (SMBIOS information such as BIOS version) on UEFI only systems
 - Made some changes in the network test to fix an overflow that could coccur in the max delay timing calculation which could show a max delay higher than the current timeout value when no error occured.

Release 8.1 build 1022 - 3 April 2017
 - Applied USB Timeout set in USB preferences to USB3 benchmark test
 - Fixed a missing default config file error message at startup
 - Fixed a crash that could occur during system information collection in 32bit 
 - Fixed a bug causing a manual stop to be treated as automatic when running a script and using the toolbar stop button

Release 8.1 build 1021 - 17 March 2017
 - Added syncronization to the USB3 test threads (plugs begin with benchmark read, when all plugs finished the benchmark read test, they will start benchmark write, and then loopback test)
 - USB3 test threads will wait for all plugs to enumerate and get ready before beginning loopback and benchmark tests
 - Increased USB3 plug reenumeration timeout from 5 to 10 seconds
 - Added "Ignore USB recoverable failures" to the USB configuration tab

Release 8.1 build 1020 - 23 December 2016 
 - Changed "Operating system" in the HTML customer certificate to "Test operating system" and will only print customer and technician fields if they are filled in
 - Enabled 8b/10b error reporting in USB3 test
 - Made some changes to better track when USB3 devices are connected or disconnected (eg forced disconnection by error) during testing
 - Fixed a possible 32bit overflow error when displaying the sent and received byte count for USB3 test operations
 - Fixed a USB3 issue when device is enumerated due to high number of link layer errors (more than 64 link layer errors per 100msec)
 - Fixed a bug in USB2 test where inbuffer/outbuffer was overwritten by IOCTL_EZUSB_GET_LAST_ERROR after read/write failure which caused some trace logging inconsistencies
 - Fixed a scripting bug where numbers with decimal points were not being parsed correctly (like disk test file size)

Release 8.1 build 1019 - 25 October 2016 
 - Now properly signalling a manual stop to the script so post test actions will be followed correctly, previously all stops during a script were treated as "Automatic"
 - Fixed a bug when USB3 plug fails benchmark mode in USB high-speed mode, this could cause an error if using the USB3 plugs on a USB2 port when the test switched from benchmark to loopback
 - Reduced the amount of time the 2D test will wait between tests when on a low duty cycles
 - Fixed a window redraw issue where the 2D lines and bitmaps test was not always updating correctly after the lines test on some systems
 - Fixed some display issues (wrong hard drive letter shown) sometime when a test config was created from default or moved between system with different disk setups
 
Release 8.1 build 1018 - 8 August 2016 
 - Fixed a bug with detecting and starting serial port tests when running in WinPE on some systems
 - Changed the behaviour of the raw disk test when running in WinPE to be the same as running in a full version of Windows, now the RAW disk test will run on a disk that contains partitions unless there are windows files detected.
 - Fixed a possible long wait for system information sometimes when launching BurnInTest

Release 8.1 build 1017 - 21 July 2016 
 - Fixed a bug where the USB error count could be reset during a test cycle
 - Fixed a bug when scripting multiple reboots was not always processing each reboot correctly
 - Changed the "Butterfly test skipped" warning message to information level so it is logged but not counted as a warning
 - Changed the default sample period for temperature collection to 10 seconds (from 1 second). This can prevent crashes on some systems where frequent temperature polling can cause a device driver crash. 

Release 8.1 build 1016 - 20 June 2016 
 - Added a benchmark test phase for USB3 as part of the test
 - Added USB3 low level error reporting to the trace level log
 - Added new error message to 2D test when EMC + test pattern test is selected and only 1 monitor is present
 - Added OBEX FTP transfer type to bluetooth test
 - Made some changes to disk test to skip butterfly test when running Cylic pattern and an SSD is detected
 - Now filtering "Bluetooth" named network cards from "All available ethernet" and "All available 802.11" network test options
 - Added "Microsoft Virtual" to list of filtered out adapter form network test to account for "Microsoft Virtual WiFi Miniport Adapter" and "Microsoft Virtual WiFi Miniport Adapter"
 - Fixed a bug where the advanced net test window was not updating the statistics when running the test on a teamed group of network cards. Sent/Recv is now displayed but load and load balancing is not available (missing performance counters).
 - Fixed a bug with management console inital connect not sending all the system information across
 - Removed whitespace padding in some HTML output

Release 8.1 build 1015 - 3 May 2016 
 - Now filtering "Bluetooth" named network cards from "All available ethernet" and "All available 802.11" network test options
 - Now filtering "Microsoft Virtual" adapters from all network test options to ignore "Microsoft Virtual WiFi Miniport Adapter" and "Microsoft Virtual WiFi Miniport Adapter"
 - Removed whitespace padding in some HTML output
 - Fixed a bug with management console initial connect not sending all the system information sometimes
 - Updated system information library, fixes a bug that was preventing some NVMe hard drive temperatures from being read

Release 8.1 build 1014 - 22 April 2016 
 - PCIe test changed to be compatible with PCIe firmware version 2.0.1000.0. PCIe cards with older firmware version will need to use an older build of BurnInTest or have their firmware updated.
 - Changed a GPGPU error to show an error code where available
 - Added unique error message when failing to play back MP3 file for sine wave tone in 2D reference test pattern
 - Fixed a crash in the 2D EMC - scrolling characters test when there were more than 4 monitors connected to a system (test still only supports 4 monitors)
 - Fixed a bug when using the plugin option "Ignore no operations" with pre-test plugins could see a "no operations" error still occur during the normal test phase (after the pre test plugins had finished)
 - Changed text box contents on pass/fail window to pass or fail to assist automated scripting programs getting the result
 - Filtered out Microsoft virtual adapters "Microsoft Hosted Network Virtual Adapter" and "Microsoft Wi-Fi Direct Virtual Adapter" from network test
 - Fixed a bug when the webcam test was used in a script that would prematurely end the main tests

Release 8.1 build 1013 - 23 March 2016
 - Removed some unnecessary 2D trace level 2 information from the log
 - Stopped an incorrect error being logged for the midi sound test in some cases that was occurring after the tests have been stopped.
 - Fixed a bug in the raw disk read only test where the test would attempt to read past the end of the disk in some cases (if the total amount of bytes on the disk was exactly divisible by 64MB)
 - Changed how the USB3 device handles are opened, they are now created before starting the test threads to prevent the UI locking up once the load on the USB system becomes heavy when starting lots of plugs at 100%
 - System information library updates	
	- Temperature support for NVMe drives
	- Added retrieval of Device Info + SMART values for NVMe Samsung and Intel SSD drives
	- Fixed an issue with multiple network cards not being displayed in system information

Release 8.1 build 1012 - 15 January 2016
 - Fixed some clipping issues with the OK/Error buttons in the webcam test
 - Fixed a bug stopping a script or test from finishing correctly when running the webcam test
 - Fixed a bug preventing the MAC address of network cards being displayed in the system information
 - Fixed a bug where the fullscreen resolution setting when running the 3D test in fullscreen 
   (non windowed) mode was being ignored and the test would run at the default resolution
   
Release 8.1 build 1011 - 10 December 2015
-  Added extra logging on memory verification errors
-  Added IP addresses display for network cards in system information
-  Added simple HTTPS authentication entry method to the management console, a windows 
   username/password entry dialog will be displayed when authentication is required
-  Made some changes to log less 2D errors for memory corruption (eg if driver crashes). 
   Instead of logging an error for each 4 byte address failure will now log one error 
   with a total count in the error message
-  Fixed a bug where if a script was automatically stopped on an error condition
   (using "SETERRORS ACTION stop") it would flag the stop as a manual (not auto) stop
   which would cause a message box prompt to be displayed before running a post test 
   application rather than launching it automatically.

Release 8.1 build 1010 - 28 September 2015
- Added BIOS serial number to system information display
- Fixed a MIDI error in windows 10 that was caused by the system information library
  used by BurnInTest  when reading hard disk temperatures
- Corrected a display and test start issue when loading a config file with "Auto select"
  hard drives enabled

Release 8.1 build 1009 - 31 August 2015
- Added SETDISKDESTRUCTIVE script keyword to allow physical disks to be selected for raw disk testing 
- Fixed a bug stopping more than 50 disks from being selected for testing (current test limit is 80).
- Fixed a bug in the "Random data, random seeking" test pattern that could cause verification errors
  in large (>4GB) test files.

Release 8.1 build 1008 - 12 August 2015
- Corrected a bug introduced in v8.1.1006 where BurnInTest would not start on 
  Windows XP.

Release 8.1 build 1006 - 5 August 2015
- Added additional Intel i3/i5/i7 Broadwell desktop, Xeon E3 and AMD Kaveri 
  refresh CPU system information.

Release 8.1 build 1005 - 3 August 2015
- Correction to the Operating system displayed for the latest Windows 10 releases.
- Added additional Intel Skylake CPU specific system information.

Release 8.1 build 1004 - 27 July 2015
- Added Intel Skylake CPU specific system information.
- Improved the memory test error messages to include leading "0"s for the 
  read and expected values.
- System information updated to support displaying video card memory greater 
  than 4GB.
- Memory SPD information Jedec manufacture ID list updates.

Release 8.1 build 1003 - 17 July 2015
- Changes to correct a crash on start-up with HTML reporting of SPD data on a 
  system with a large number of memory sticks.
- Correction to the SETLOG script command for "TRACELEVEL NO".
- Correction to the BITaccess lock down for CPU, GPGPU and PCIe.

Release 8.1 build 1002 - 15 July 2015
- Minor improvements and corrections to the PCIe test. 
- Changes to correct a crash with formatting SMART attribute data that can 
  occur on very long test runs, when the disk test checks SMART data and disk 
  temperature monitoring is turned on.
- Changes to correct a crash on start-up collecting SMART data from Adaptec 6, 7 
  and 8 Series Hardware Raid Controllers with new firmware.
- Added debug logging and a work around for BurnInTest not stopping on Windows 
  embedded.

Release 8.1 build 1001 - 8 July 2015
- Minor improvements and corrections to the PCIe test. 

Release 8.1 build 1000 - 6 July 2015
- New PCIe loopback and voltage test. Requires PassMark PCIe 2.0 loopback card.
- Improved the Bluetooth test for iPads and Android smartphones.
- System information changes:
  - Removed some debug message boxes for Ivy bridge CPUs.
	- Added system information for AMD Radeon R9 Fury X, R9 390X, R9 390, R9 380, 
	  R9 M375, R9 M370X, R7 370.
	- Fixed memory SPD for AMD Hudson-2/Hudson-3 SMBus systems. Added decoding of 
	  Maximum Activate Count (MAC) and Maximum Activate Window (MAW) SPD fields in 
	  DDR3 rev 1.3.
	- Improved SMART data collection for disk controller drivers that identify as 
	  SCSI drives.
  
Release 8.0 build 1046 - 19 June 2015
- Correction to the "SETNETWORK" scripting command for setting the "LOOPBACK"
  test mode.

Release 8.0 build 1045 - 10 June 2015
- Correction to the command line parameter, -n [minimum volume size in MB]. 
  Previously could only be used to exclude disks less than about 2GB.
- Added new debug logging for a USB 2.0 loopback error.

Release 8.0 build 1044 - 29 May 2015
- Added a silent version of force debug logging "-US", where the debug log 
  filename message boxes are not displayed.

Release 8.0 build 1043 - 22 May 2015
- Corrected a rare crash bug when graphing temperature data.
- If the battery test reports a capacity and designed capacity of 0, an error 
  is now raised.
- The following scripting command can now include environment variables in the 
  parameters for expansion to strings: SETSERIAL, SETTECHNICIAN, SETCUSTOMER, 
  SETMACHINETYPE, SETNOTES. SETNOTES can include "\n" as a new line break.
- SPD system information added for the Intel Sunrise Point chipset. 
  Improvements for DDR3 and ECC DDR2 SPD information.
- New debugging logging added for when a crash occurs while running on WinPE.
- Updates to help.

Release 8.0 build 1042 - 29 April 2015
- Minor change to the Random data with random seeking physical disk test and 
  additional debug logging.

Release 8.0 build 1041 - 27 April 2015
- The disk test has been optimized to run faster, especially for disks that 
  are faster than about 800MB/s.
- The physical disk test may report "Unable to unmount volume" if partition 
  information is found on the disk, but no Volume is mounted. This has been 
  corrected.
- Corrected a possible crash bug with the Butterfly seek disk test if BurnInTest 
  is unable to get the disk volume information.
- Reduced the time taken to collect System information.
- Corrected a possible crash bug if BurnInTest was started before the disk 
  system information was collected.
- Updated CPU system information: Added Intel Cherry Trail, Braswell, Airmont 
  and Knights Landing. Added Intel Bay trail temperature monitoring. Intel 
  Core 2 Duo E6000 and E4000 temperature monitoring updates. Added newer Intel 
  Haswell and Broadwell CPU system information. Added newer AMD CPU system 
  information.
- Improvements to memory information collection for SPD decode of DDR2 ECC, 
  the Intel 5100 chipset, Intel Wildcat Point PCH and decoding of DDR3 rev1.1 
  timings.
- Added System information for the AMD HD 8690A GPU.

Release 8.0 build 1040 - 27 March 2015
- Changes to the new 2D EMC reference test pattern test:
  - Alt-tab can now be used to bring the BurnInTest controls on top of the test 
    pattern.
  - The test pattern is now supported on up to 4 monitors (more if graphics 
    system supports duplication onto more monitors).
  - A new option to display the scrolling characters on the primary display and 
    the test pattern on a second display has been added.
  - 4:2:2 and 4:2:0 sampling has been added to the relevant zones of the test 
    pattern.
- If testing a system with greater than 2GB of RAM when using 32-bit BurnInTest 
  on WinPE, then the test RAM size is limited in a more appropriate manner. 
  Note: Systems with more than 2GB of RAM should be tested with 64-bit BurnInTest.
  
Release 8.0 build 1039 - 18 March 2015
- New 2D EMC reference test pattern test.
- Reduced the time to collect memory SPD information in some scenario's.
- New system information for some newer CPUs.
- Some CPU information collection is now skipped on Linux VM's.
- Licence agreement updated.
- Minor updates to help.

Release 8.0 build 1038 - 18 February 2015
- Correction for Windows 10 when driver verifier is turned on for Blue Screen
  INVALID_KERNEL_HANDLE. Note: this issue did not occur if the driver verifier 
  was not turned on.
- Additional system information added for new Haswell-E Xeon E7 v3.  

Release 8.0 build 1037 - 9 February 2015
- Correction to a verify error in the disk High/Low test on a physical disk.

Release 8.0 build 1036 - 6 February 2015
- Fixed a black screen issue related to reading DDR4 RAM SPD data.
- Fixed memory SPD information not being retrieved for Sandy Bridge-E/Ivy Bridge-E 
  chipsets when failing in some scenarios.
- Improved support for running on Virtual Machines.

Release 8.0 build 1035 - 2 February 2015
- Added debug information for 3rd party temperature monitoring.

Release 8.0 build 1034 - 30 January 2015
- Added debug information for 3rd party temperature monitoring.
- Added R9 285, HD 7730 to video card system information.
- Added detection of whether BurnInTest is running on a Virtual Machine, or real 
  hardware. In some cases, some CPU information collection will be skipped on 
  VMs.

Release 8.0 build 1033 - 28 January 2015
- Added debug information for 3rd party temperature monitoring.

Release 8.0 build 1032 - 7 January 2015
- Changes to the collection of Memory SPD information (for Intel801 SMBus) and
  additional debug information.

Release 8.0 build 1031 - 7 January 2015
- A CPU test bug that could cause false CPU errors on 32-bit BurnInTest has been
  corrected. This problem was introduced in 32-bit BurnInTest 8.0.1026.
- Changes to the collection of Memory SPD information (for Intel801 SMBus).
- System information added for new Intel Broadwell-U CPUs.

Release 8.0 build 1030 - 2 January 2015
- Changed the date format in the reports to be consistent with the format of 
  other dates. This removes the USA specific formatting MM/DD/YYYY.
- Memory SPD system information updates.

Release 8.0 build 1029 - 19 December 2014
- A possible crash bug on start-up has been corrected for the collection of DDR4 
  memory information.

Release 8.0 build 1028 - 12 December 2014
- It was possible that the disk test using the physical disk test mode could 
  report a false error. This has been corrected.
- A possible crash when collecting system SMART information on start-up has 
  been corrected. 
- Minor improvements to system information collection.

Release 8.0 build 1027 - 10 December 2014
- BurnInTest 8.0.1026 did not work on Windows XP. This has been corrected.
- On receiving GPGPU device errors, BurnInTest will now pause the GPGPU test 
  for a minute.

Release 8.0 build 1026 - 8 December 2014
- Scripting for SETTEST GPGPU and UNSETTEST GPGPU corrected.
- The no operation checks have been extended to check for no operations per 3D 
  test thread (when running more than one 3D test and only some of the tests 
  are not working).
- Added support for XMP2.0 SPD memory information.
- Added custom names for AMD A10/A8/A6 integrated cards (eg AMD Radeon R7 
  A10-7850k).
- On receiving a GPGPU verification error, BurnInTest will now pause the test 
  for a short duration.
- Additional GPGPU detailed logging.
- Minor corrections.
- Updates to help to improve performance on high DPI displays.

Release 8.0 build 1025 - 17 November 2014
- The disk test, random seeking test mode, has been changed to resolve 
  verification errors where the value 66 is incorrectly read.
- 32-bit BurnInTest could crash on starting the disk test with a large number of 
  disks under test, the random seeking test mode selected and 64MB test blocks 
  specified. This has been corrected.

Release 8.0 build 1024 - 14 November 2014
- Correction for collecting memory SPD information on some Intel ICH SMBUS based
  systems.
- Correction for temperature display when using 3rd party tools: SpeedFan and 
  Hmonitor.
- Updates to help.

Release 8.0 build 1023 - 12 November 2014
- Correction to the 2D video memory test on High DPI monitors, where no 
  operations would be reported. Note: It is normal for the 2D display to be 
  smaller on high DPI monitors.
- Minor correction to start-up of GPGPU test. Added new debug logging.
- System information added for newer Broadwell CPUs.
- Corrected pop-up menus broken in V8.0.1013.
- Status bar could display "USB not detected", this has been corrected.

Release 8.0 build 1022 - 10 November 2014
- Corrected a bug where BurnInTest could crash on closing the disk test.
- The MachineID for the BurnInTest Management Console can now be specified as a 
  command line parameter, -MGT <MachineID>, where <MachineID> can be text or
  an environment variable that will be expanded.
- If the MachineID is changed in Configuration->Report information, and BurnInTest
  is connected to a management console, then BurnInTest will now reconnect with 
  this new MachineID.
- BurnInTest Plugin paths can now be specified with (or without) quotes. 
- Corrected the number of L1 and L2 CPU caches on Bay Trail CPU's.
- System information improvements for AMD video cards. 
- System information improvements for Memory SPD collection (for IMC1 SMBus not 
  available for Haswell chipsets).
- Updates to help.

Release 8.0 build 1021 - 24 October 2014
- Corrected a bug in BurnInTest where the disk test could cause 32-bit 
  BurnInTest to crash after a long period of testing.
- The number of CPU caches reported has been corrected for Haswell-E.

Release 8.0 build 1020 - 22 October 2014
- The disk test is now paused if BurnInTest is running out of Virtual memory. 
  Increased debug logging for the disk test.

Release 8.0 build 1019 - 17 October 2014
- Additional Intel Silvermont CPU (ATOM) non-burst frequency measurement 
  information added.
- The option to lock the tests to a single CPU has been corrected.
- Improvement to wrong license key version message.

Release 8.0 build 1018 - 15 October 2014
- Additional Intel Silvermont CPU (ATOM) non-burst frequency measurement 
  information added.
- Single 32-bit and 64-bit installation package changes.
- New debug logging for the sound loopback test.

Release 8.0 build 1017
WIN32 release 13 October 2014
WIN64 release 13 October 2014
- Intel Silvermont CPU (ATOM) non-burst frequency measurement information added.
- Single 32-bit and 64-bit installation package.

Release 8.0 build 1016
WIN32 release 10 October 2014
WIN64 release 10 October 2014
- Corrected a memory test compatibility issue with Windows XP where 
  "Unknown error" could be reported.
- Corrected a possible crash bug when stopping the Sound loopback test.
- Intel Silvermont CPU (ATOM) frequency measurement improved.
- System information for future Intel Atom Processor Based on Silvermont 
  Microarchitecture added.
- Added default name for AMD A10/A8/A6 integrated cards (AMD Radeon R7).
- Added support for AMD Radeon HD 8xxxD/7xxxD/6xxxD/8400/8330/6320 cards.
- Changes for multiple nVIDIA card detection.
- Changed references from ASCII log files to text log files.

Release 8.0 build 1015
WIN32 release 3 October 2014
WIN64 release 3 October 2014
- Reporting of Windows 10 has been added. Initial testing with Windows 10 
  Technical preview completed.
- Corrected a possible crash bug in the sound loopback test. 
- Correction to the Advanced Network test to allow more than one Endpoint IP to 
  be used in a test.
- Improved the handling of USB 3.0 testing when the system goes into/out of sleep 
  states.
- CPU icon display position corrected on high DPI monitors.
- Updated the nVIDIA library BurnInTest uses for graphics card information and 
  temperature collection.

Release 8.0 build 1014
WIN32 release 29 September 2014
WIN64 release 29 September 2014
- Replaced the "Save window as image" GIF and EMF options with PNG.
- Tested on Windows 8.1 To Go. Additional logging added for this case.
  Automatic disk selection changed to not test the WTG USB drive, C: drive.
  Documentation updated to cover WTG and its default SAN policy to set local 
  disks offline and how to test these disks with BurnInTest.

Release 8.0 build 1013
WIN32 release 22 September 2014
WIN64 release 22 September 2014
- Corrected a crash bug on start up on a system with invalid DDR3 SPD data.
- Improvements to Mouse wheel scrolling to remove flicker on updates and 
  temperature graph scrolling.
- Improvements to the display on high DPI monitors and printing results.

Release 8.0 build 1012
WIN32 release 19 September 2014
WIN64 release 19 September 2014
- Improvements to the display on high DPI monitors.

Release 8.0 build 1011
WIN32 release 19 September 2014
WIN64 release 19 September 2014
- Corrected a crash bug on mouse wheel scrolling. 
- Corrected a possible crash bug in the sound loopback test. 
- Improvements to the display on high DPI monitors.

Release 8.0 build 1010
WIN32 release 17 September 2014
WIN64 release 17 September 2014
- BurnInTest can now run without DirectX being installed on the system (e.g. on 
  WinPE 3.0) - as per BurnInTest 7.0.
- High resolution CPU images for high DPI monitors.
- When run under WinPE, the disk test could cause BurnInTest to run out of 
  virtual memory after a long period of testing. The disk test would stop and 
  BurnInTest could crash. This has been corrected.

Release 8.0 build 1009
WIN32 release 12 September 2014
WIN64 release 12 September 2014
- Improved support for high DPI monitors.
- Improved support for DDR4 memory system information.
- Haswell-E non-turbo speed collection + Codename, Socket, Lithography, stepping.
- Memory system information (SPD) support added for Ivy Bridge-EX/Haswell-EX 2nd 
  memory controller.
- Corrected a crash bug on collecting SMBIOS system information on a particular 
  system.
- Disk drive temperature support changed to no longer use vendor specific 
  temperature SMART parameters.
- The 2D lines and bitmaps test will now pause after and error.
- Reduced the amount of some less important level 2 activity trace logging.
- Updated help for the above changes and additional information about 3D errors.

Release 8.0 build 1008
WIN32 release 29 August 2014
WIN64 release 29 August 2014
- CPU system information updates (including AMD Beema, Mullin, Intel BAY trail).
- When run under WinPE, the disk test could cause BurnInTest to run out of 
  virtual memory after a long period of testing. The disk test would stop and 
  BurnInTest could crash. This has been corrected.

Release 8.0 build 1007
WIN32 release 22 August 2014
WIN64 release 22 August 2014
- Added debug logging for the 3D test to now log WM_DISPLAYCHANGE, WM POWER and 
  WM_POWERBROADCAST messages when activity trace level 2 logging is specified.

Release 8.0 build 1006
WIN32 release 20 August 2014
WIN64 release 20 August 2014
- Some additional system information added for Intel Broadwell CPUs and the 
	next generation of Intel Xeon Processor Family based on Haswell.
- Corrected a bug where a scripted test that turns on Automatic temperature 
  monitoring, may not turn on temperature monitoring.
- Added a new option for the disk test (command line parameter "-ADR") to also 
  automatically select removable disk volumes (and not just automatically 
  select fixed disk volumes).
- Added a new command line parameter -HX, that will set the screen resolution to 
  1024x768x32 and exit immediately.
- The "Activity event" have been renamed to "Summary results written to log 
  file" to be more meaningful.
- The memory test now leaves a little more memory headroom if the disk test is 
  running.  
- Minor changes to help.

Release 8.0 build 1005
WIN32 release 11 August 2014
WIN64 release 11 August 2014
- Corrected a possible crash on exiting BurnInTest if the GPGPU test had been 
  run.
- Corrected a possible crash with level 2 trace file logging of the event log 
  events, where the event log is very large.
- A possible scenario where Intel CPU temperatures are sometimes not collected 
  has been corrected.
- Minor debug logging changes.

Release 8.0 build 1004
WIN32 release 6 August 2014
WIN64 release 6 August 2014
- A new Pre-test option has been added, Detect hardware and turn off tests. 
  When selected BurnInTest will detect current hardware and if the hardware is 
  not found on the system then the test is turned off (see help). 
- A new option to automatically select all physical disks under WinPE has been 
  added, "-PHYSDISK". Note: this test will destroy all data on all of the disks.
- Temperature monitoring is now turned on by default.
- Corrected a memory leak that occurred when the System information Window was 
  updated (resized or scrolled).
- If the system has run out of memory, and the disk test is unable to create 
  a test data buffer, the disk test is now stopped.
- Fixed a bug where (1) BurnInTest did not exit properly when the Disk self 
  test was run and (2) the GPGPU test did not work when run with the disk self 
  test. 
- Fixed a bug where BurnInTest could crash on creating a 2nd Customer 
  Certificate log file.
- Fixed a bug where BurnInTest could crash on the GPGPU test encountering an 
  error such as out of memory. 
- Fixed a bug where BurnInTest could crash on start-up when collecting memory 
  SPD data.
- Fixed a bug where BurnInTest could crash on exiting.
- Fixed a bug where if there were no optical drives on the system, then an error 
  was displayed when Auto select optical drives was selected. 
- When a larger number of tests are run, the memory test will now leave a 
  little more memory headroom.  
- An error is now displayed on starting a non-scripted test if the Plugin test 
  is selected but no Plugin files are specified.
- Added check for AMD powerexpress when searching for video cards (using the AMD 
  API) to try and correctly detect AMD graphics cards in laptops when using in 
  dual setup with intel onboard card.
- Added System information for AMD R5 M230, R5 M255, R7 M260, R7 M265, R9 M275X, 
  R9 M265X, R9 M270X and R9 M290.
- The "Check updates" option in the PC Test kit build now includes information 
  specific to updating the PC Test Kit.
- Minor debug logging changes.
- Minor changes to help.

Release 8.0 build 1003
WIN32 release 17 July 2014
WIN64 release 17 July 2014
- When BurnInTest is run in preferences editor mode, all relevant test modes 
  are now shown for physical disks.
- Added DVD burn error message text (not just the error code).
- Changes to only flush duplicate events if configured to summarize duplicates.
- Increased 3D test debug logging.
- Minor updates to help.

Release 8.0 build 1002
WIN32 release 11 July 2014
WIN64 release 11 July 2014
- Correction for reported BurnInTest crash on exit.
- Additional debugging for the Video Playback test.

Release 8.0 build 1001
WIN32 release 4 July 2014
WIN64 release 4 July 2014
- It was possible that the Webcam test could fail on the first test, this has 
  been corrected.
- It was possible that Intel GPU temperature sources were incorrectly reported, 
  although they are not supported. Intel GPU temperatures are now not reported.
- If the Temperature preferences are not changed and "Cancel" is selected, the 
  current temperature sensor data is now retained (not reset).
- AMD Radeon R9 295X2 and R7 260 video cards have been added to System 
  Information.
- Corrected the Disk serial number in reports (was shown as NA).
- System Information Memory SPD improvements
	- Added support for Haswell-E SMBus (for DDR4)
	- Added support for nForce MCP79 secondary SMBus
	- Added DDR4 SPD decoding
	- Fixed SPD decoding of manufacture information
	- Added DDR3 module type specific decoding  
- The price for BurnInTest Standard has been corrected.
- Improvements to help.

Release 8.0 build 1000
WIN32 release 16 June 2014
WIN64 release 16 June 2014

TESTS

- New GPGPU test:
  - The GPGPU test exercises and verifies the GPU's General Purpose computing 
    operations (rather than 3D type operations). The GPGPU tests are a bit like 
    the CPU tests, but the tests are run on the GPU. The GPGPU test load is 
    user selectable. 
  - The GPGPU test runs on all detected GPUs (to a maximum of 8 GPUs). The GPUs 
    that are being tested are listed in the GPGPU test window. 
	  
- New Webcam test:
  - Added an integrated Webcam test to BurnInTest Pro. This test allows a 
    Webcam display window to be opened as a pre-test. BurnInTest will report 
    errors opening the Webcam window and the user can also report a visual 
    display error (via a button). Scripting commands have been added to support 
    this feature, e.g.:
      SETTEST WEBCAM, UNSETTEST WEBCAM, RUN WEBCAM

- New battery test
  - Added an integrated Battery test to BurnInTest Pro. This test checks the 
    battery levels in absolute or percentage terms. These checks can be carried 
    out before the main tests, and/or during the main tests. Scripting commands 
    have been added to support this feature, e.g.:
      SETBATTERY PRE_TEST YES MAIN_TEST YES USE_THRESHOLD YES THRESHOLD 30000 
      SETBATTERY PRE_TEST YES MAIN_TEST NO USE_PERC_THRESHOLD YES PERC_THRESHOLD 95 

- New Microphone test 
  - Added an integrated Microphone test to BurnInTest Pro. This test allows a 
    microphone test window to be opened as a pre-test. The test allows 20 seconds 
    of audio to be recorded via the microphone that can then be played back to 
    verify the Microphone input is OK. BurnInTest will report errors opening the 
    Microphone input and the user can also report an audio error (via a button).
      SETTEST MICROPHONE, UNSETTEST MICROPHONE, RUN MICROPHONE

- Improved the CPU test:
  - Added a new CPU test for AES. Scripting updated to allow AES testing.
    SETCPU AES YES

- Improved the Memory test:
  - BurnInTest can now monitor and report low level hardware errors, like 
    corrected ECC memory errors, CPU and PCI-E errors, based on the Microsoft 
    Windows Hardware Error Architecture (WHEA). 

- Improved the Disk test:
  - Increased the default Disk test duty cycle from 50% to 100%.
  - Added larger disk test block size options from 2MB to 64MB. In many cases 
    this allows faster testing. 
  - Increased the Blocksize default from 0.25MB to 4MB.
  - Optimized the Sequential, HighLow and Random test patterns to reduce the 
    time required to test a disk and to increase load.
  - Added a user defined test pattern (eg: 55AA or F0F0) where one user defined 
    test pattern can be specified. Added scripting commands to support this, e.g:
      SETDISK DISK c: MODE userdefined BLOCK 65536
      SETDISK USERPATTERN 00AA00AA00AA00AA
  - Added a Physical disk read test, that tests that all sectors on the physical 
    disk can be read. This can be useful for a number of reasons including 
    testing that a disk is the size that it reports it is (we have seen disks and 
    UFDs that have this issue).
  - The mechanism to calculate the disk test throughput (MB/sec) and to trigger 
    the Slow Disk Threshold has been improved. 
  - Corrected a Disk test crash bug with the High/Low test mode.
  - Changed the description of Automatically select disk drives to better reflect 
    that SSDs are also selected with this option (not just hard disks).

- Improved the Standard Network test:
  - Increased the number of Network ports that can be tested from 12 to 20.
    Changed scripting to support these options, e.g.:
      SETNETWORK  ADD13 "192.168.0.13"
  - Improvement to the verification of the IPv6 Standard network test packet.
  - When an error ratio is specified with the standard network test, the number 
    of packets required before the ratio is considered to be meaningful has been 
    increased.
  - Preferences->Network now warns that at least 1 destination address must be 
    specified.

- Improved the Bluetooth test:
  - Bluetooth updated to work with more recent devices, e.g. Nexus 5. 
    Specifically, if the "File Transfer" profile is not found on the Bluetooth
    device, BurnInTest will now attempt to connect to the device using its 
    address and a range of ports.
  - Improved the error message when a connection to the device fails.

- Improved the Advanced Network test:
  - Added an automatic detection and testing of Network Adapters option in the 
    Advanced Network test. This allows easier testing across systems with 
    different network card configurations.
  - Optimized the Advanced network test to provide a greater load with lower CPU 
    utilization (i.e. test higher network loads). Also, increased the default 
    Advanced Network Block size from 1000 to 16384 to increase the default 
    Network load.
  - Better support for systems with VMWare or VirtualBox installed (Network 
    port detection).

- Improved the Sound loopback test:
  - The Sound loopback test has been changed from mono to stereo. BurnInTest
    now plays a stereo waveform and records and analyses each channel. The left 
    and right channel waveforms are displayed in the test window and errors are 
    reported for either the left or right channel.
  - Very short tests are now possible (e.g. to verify correct cabling) down to 
    about 4 seconds (by setting a duration of less than 30 seconds, and the 
    number of cycles to 1. 
  - Sound preferences now displays the waveform capable input and output 
    devices on the system, to make it easy to determine which is the default 
    device (0), and what will be used for the test.
  - The output device is now selectable using BurnInTest scripting, via e.g.
    SETSOUND TEST LOOPBACK DEVICEOUT "Speaker". BurnInTest 7.x and earlier use 
    the default output device.

- Improved the 3D test:    
  - Higher load through higher resolution textures and 3D objects. Improved the 
    test for Intel integrated graphics cards.

- Improved the USB test:
  - The USB 3.0 Loopback test has been changed to use a larger burst length to 
    increase the USB system loading.
  - Improvements to detecting PassMark USB 3.0 Loopback plugs in some scenarios.

- Improved the Video Playback test:
  - Additional error information now reported for the Video Playback test.
  - Corrected a Video playback test crash bug that could occur in rare scenarios 
    at the end of a video clip.


SYSTEM INFORMATION
- Separate Operating System descriptions for Windows 8 and Windows 8.1.

- Updated CPU system information for newer CPUs.
- Updated CPU features: AVX, AVX2, XOP, FMA3, FMA4
- Non-turbo CPU speeds now measured and reported for Ivy Bridge (and later) 
  Xeons.
- Summarized some CPU features to fit them all on the CPU test window.
- Minor CPU temperature reporting changes for AMD Family 15h, Models 0h-0Fh and 
  30h-3Fh (e.g. A10-7850K).
- Added temperature monitoring of Intel Atom NXXXX CPUs (e.g. N2800).
- If AMD CPU temperatures are unable to be retrieved, BurnInTest no longer 
  reports these temperatures as 0.
- AMD Athlon(tm) II X4 6xx socket type corrected.

- System information added for 8970M/7730M/4810 video cards.
- System information added for AMD R9/R7 and 8700M/8800M video cards.

- Added disk volume GUID information
- The maximum number of SMART devices for System Information reporting has been
  increased from 32 to 64.

- System information memory SPD improvements:
  - BurnInTest now reports memory modules greater than 32GB.
  - Increased the number of reported memory modules from 16 to 32.
  - Improved memory device information (added support for DDR3 SPD revision 1.2 
    and 1.3).
  - Improvements to system memory information (for some systems with Intel LPC's, 
    Ivy Bridge-E IMC SMBus, AMD/ATI/nVidia SMBus and Intel Haswell-E/Wellsburg 
    chipsets). Improvements to memory capacity information.
  - Multiple SMBus controllers are now supported, for RAM connected to 
    separate CPUs.
  - Improvements to Sandy Bridge-E chipset memory module reporting.
  - Intel ValleyView chipset, Intel 5 Series chipsets and SiS96x chipset support
    added.
  - Improved collection of memory (SPD) information: Added support for retrieving 
    info for all RAM modules on Supermicro server boards. Added support for the
    VT8237S chipset. Added support for enabling SMBus on the Intel X79 Express 
    Chipset. Fixed incorrect decoding of number of banks in DDR2FB SPD that 
    caused the memory stick size to be reported incorrectly.
  - Changed the memory module number in the system information to be 0-based.
  - If BurnInTest failed to collect Memory SPD information from some systems, it 
    was possible that BurnInTest would try forever. This would not allow the user
    to enter preferences. This has been corrected.

  - Added reporting on Battery information to BurnInTest Pro (without the need 
    of BatteryMon).

  - Fixed a crash bug on start-up when collecting system information on a system 
    with a very large number of disks.
  - Rare crash on collecting Disk SMART information fixed.

REPORTING
- The test configuration details can now be saved to a text report (File->Save 
  Test Configuration Text As...) or to an Activity level 1 trace log file. 
  This can help record the test configuration of a test run or be used to check 
  the test configuration.
- A statistics report has been added to log test monitoring data in a CSV (Comma 
  Separated Variable) format for post test analysis. Currently this includes 
  data logging for temperature, fans* and voltage*. *3rd party HMonitor or 
  SpeedFan software is required to monitor fans and voltage.
- Temperature reporting and graphing now supported down to -50C (previously above 
  0C) where supported by the temperature source.
- Added fields to the Customer Test Certificate: System model, Motherboard 
  manufacturer and Motherboard serial number.

OTHER IMPROVEMENTS
- Pre-tests may now be run directly or scripted to run without a main body of 
  tests. For example, a webcam pre-test and touchscreen plugin pre-test may be 
  run with no other tests. Post test actions will occur after the Pre-tests if 
  there are no main tests to run.
- On double clicking a result on the Results window, if there is no error 
  then the test description in help is displayed instead of the error 
  descriptions.
- Background watermark on System Information page, so that at a glance it is obvious 
  whether BurnInTest V7.x or V8.x is running.
- Minor temperature logging change.
- Corrected a possible crash bug when printing results as a post test action.
- Corrected a bug where if all "RUN" script commands failed (e.g. due to a 
  script syntax error) then no PASS/FAIL window will be displayed.
- It is now possible to skip the collection of specific system information on 
  start-up, including CPU turbo mode, SMBIOS and SPD data. This is an extension
  to the existing "-W" command line parameter.
- Tested and documented network PXE booting a Windows image with BurnInTest
- When running BurnInTest on WinPE, BurnInTest will no longer attempt to create 
  a debug file (minidump) on encountering a crash.
- BurnInTest no longer converts old configuration files made with BurnInTest 6.0.1012
  or earlier.
- Corrected a crash bug when starting the 3D test on a system with more than 
  10 monitors.
- Help updated for V8.0 and other minor improvements.


Release 7.1 build 1017
WIN32 release 18 September 2013
WIN64 release 18 September 2013
- Corrected a crash bug when collecting disk SMART information during startup 
  (problem reported on a single system).
- Windows 8.1 support confirmed (no changes made to BurnInTest). Minor change to 
  Rebooter.

Release 7.1 build 1016
WIN32 release 16 September 2013
WIN64 release 16 September 2013
- CPU temperature monitoring and additional CPU information for Intel Silvermont/ 
  Bay Trail and Ivy Bridge-EP (e.g. i7-4930K).
- New scripting commands: SETTEMP THRESHOLD, SETTEMP AUTO_CPU, SETTEMP AUTO_GPU, 
  SETTEMP AUTO_DISK and SETTEMP SAMPLE.
- If Temperature->"Stop testing on threshold exceeded" was triggered for multiple 
  temperature sources at the same time, then the Stop tests action could occur
  more than once (e.g. more than one FAIL Window could be displayed). This has
  been corrected.

Release 7.1 build 1015
WIN32 release 6 September 2013
WIN64 release 6 September 2013
- The detailed memory information could be truncated in a small number of cases.
  e.g. the serial number may not have been displayed. This has been corrected.

Release 7.1 build 1014
WIN32 release 30 August 2013
WIN64 release 30 August 2013
- Minor changes to the detection of no operations for the memory test. 
  Increased debug logging for a specific memory test no operations error. 
- New scripting commands: SETTEMP SCALE and SETTEMP AUTO.

Release 7.1 build 1013
WIN32 release 23 August 2013
WIN64 release 23 August 2013
- New scripting commands: PLUGIN SIMULTANEOUS, PLUGIN IGNORE_NO_OPS, 
  SETMANAGEMENT. Support for 5 pre-test plugin's (up from 3). Improvements to 
  very long parameter handling in scripts.
- Added an error message for the case when Bootable BurnInTest is booted from 
  WinPE 3/Win7 (or lower) when connected to a USB 3.0 port and is not supported.
- Minor software text updates.
- Help updates.

Release 7.1 build 1012
WIN32 release 21 August 2013
WIN64 release 21 August 2013
- Added 2 new scripting commands, SETTEST and UNSETTEST. These allow tests to 
  be selected or de-selected in a script (without the use of a loaded 
  configuration file).
- Corrected the default Standard Network loopback address (problem introduced 
  in 7.1.1009).
- Corrected AMD Family 15h/16h temperatures (problem introduced in 7.1.1009).
- Added logging for the disk test if the test files can not be deleted.

Release 7.1 build 1011
WIN32 release 16 August 2013
WIN64 release 16 August 2013
- Management console defaults corrected for v7.1.1009 configuration file. This 
  led to too many status updates and BurnInTest being very sluggish when 
  managing BurnInTest with the Management Console.
- The Event Log "Description" column is now resized to fill any empty screen 
  space when the BurnInTest Window is resized.

Release 7.1 build 1010
WIN32 release 14 August 2013
WIN64 release 14 August 2013
- Disk serial numbers could be displayed for the wrong physical disk. This has
  been corrected.
- Some additional information added for Intel Bay Trail CPUs.

Release 7.1 build 1009
WIN32 release 9 August 2013
WIN64 release 9 August 2013
- Updated CPU system information for newer CPUs (including: Cloverview, 
  Richland, Kabini, Temash, Delhi, Seoul, Abu Dhabi, Kyoto) as well as updated
  models for existing CPUs. Includes temperature monitoring for AMD Kabini 
  (Family 16h) based CPUs, some newer Atom CPUs and some newer Ivy Bridge CPUs.
- Updated the Disk drive serial number and volumes information, as this may have 
  been shown as "N/A" when it was available.
- The results "Last error description" column is now resized to fill any empty 
  screen space when the BurnInTest Window is resized.
- Corrected crash on start-up (for incorrectly populated SMBIOS).
- Added system time zone information to activity trace logs.

Release 7.1 build 1008
WIN32 release 29 July 2013
WIN64 release 29 July 2013
- BurnInTest Management Console functionality added. Use of the Management 
  Console requires the Web server application to be separately obtained from 
  PassMark Software and installed on a Web server.
- Battery capacity plugin has a new “/fc” flag that can be used to change the 
  comparison to use “full charged capacity” instead of “current charge capacity”.
- Fixed a disk test scripting issue where the disk volume may not have been 
  set correctly.
- Fixed an issue reporting transcend SSDs model and serial number information.
- Updated video card system information.
- For consistency of logging the disk test block number, the logged block 
  numbers during read/verify now start at 1 (as per the logging for writing 
  blocks).
- Corrected a bug where very long reporting fields (machine type, serial number, 
  notes, customer name and technician name) could be truncated shorter than 
  they should have been. 
- BurnInTest no longer supports test configuration files prior to BurnInTest V5.3.

Release 7.1 build 1007
WIN64 release 28 June 2013
- Scripting for the LPT number for the Parallel port test has been corrected.

Release 7.1 build 1006
WIN64 release 24 June 2013
- Corrected a logging filename bug where a Windows environment variable specified 
  in the "Log name prefix" field will lead to an extra "_" in the filename. 
- Corrected a logging filename bug where the BurnInTest variable %REPORTSERIAL% 
  specified in the "Log file name" field could have the first character 
  incorrectly set to "-". 
- Updated the help file.

Release 7.1 build 1005
WIN32 release 17 June 2013
- Improvements to Atom Family CPU information reporting.
- Added Temperature reporting for the Atom E680 and E680T.

Release 7.1 build 1004
WIN64 release 7 June 2013
 - Fixed a bug where the Broadcom NetXtreme II network adapter is not displayed 
   in the system information.

Release 7.1 build 1003
WIN64 release 5 June 2013
 - Added temperature reporting for Intel Haswell CPUs.

Release 7.1 build 1002
WIN32 release 3 June 2013
WIN64 release 3 June 2013
 - Added MAC address for network cards to customer certificate system summary 
 - The "Save window as image" function will now default to and only allow the 
   "Visible section only" option when the focus is on the temperature graph.
 - Fixed a bug where sometimes not all the physical network cards could be 
   displayed in the system information (more likely to occur on Windows Vista 
   and newer due to the large number of network devices).
 - Fixed a crash that could occur on some systems when collecting system 
   information.
 - Made some changes to prevent USB3 test threads from trying to start testing 
   the same plug.
 - Updated battery capacity plugin to support new /p command line parameter 
   (PRO only).


Release 7.1 build 1001
WIN32 release 12 March 2013
WIN64 release 12 March 2013
 - Added editable temperature threshold values for CPU/GPU/HDD sources when 
   using "auto select".
 - Fixed a bug where if the temperature threshold value was exceeded at the 
   very start of the test run and using "stop testing on threshold exceeded" 
   an error was logged but the test might not stop.
 - Fixed a crash that could occur when BurnInTest was exiting.
 - Fixed a crash that could occur when running the USB3 test if the plug had 
   gone into suspend mode.
 - Fixed a bug where invalid characters entered as part of a key when 
   installing to USB could cause the registration to fail after installing.


Release 7.1 build 1000
WIN32 release 4 February 2013
WIN64 release 4 February 2013
 - Added USB3 loopback plug support to the USb test.
 - USB loopback plug serial number has been added to the results and 
   logging summary.

Release 7.0 build 1017
WIN32 release 18 December 2012
WIN64 release 18 December 2012
- Added a new warning message when network card connection status 
  cannot be read
- Stopped a connection error being logged at the start of the advanced 
  network  when using Intel network cards, it is not possible to get 
  the connection status from them and was subsequently logging an error
- Fixed a bug in the scripting where the SETDISK option could sometimes 
  not set the drive letter to be tested correctly

Release 7.0 build 1016
WIN32 release 14 November 2012
WIN64 release 14 November 2012
- Added Bios version & date and network card info to test certificate
- Added %REPORTSERIAL% flag to log prefix option that will be replaced
  with the serial number entered as part of the report information
- Added serial number and volume information when available to log file 
  wen listing the disk drives as well as their drive number so they 
  can be more easily matched to the disk being tested
- Changed behaviour so "automatically monitor temperature" options
  defaults to off
- Changed behaviour so if the BitErrorClassification.txt file is read 
  only BurnInTest will no longer display an error  
- Added a new error message "2D graphics test was interrupted"
- Fixed a crash that could occur if the 2D video memory test was interrupted
  (for example by using ctrl-alt-del)
- Fixed a bug in the SETSERIALPORTS script command where the "SPEED" 
  component was not being interpreted correctly
- Fixed a bug in the SETSERIALPORTS script command where the "CYCLE_115K" 
  value for the "SPEED" component was not recognised
- Fixed a display issue where if "Automatically select temperature sources"
  was unchecked but temperature sources were still selected the temperature 
  line on the results tab would not be displayed
- Fixed a crash caused by a timing issue when collecting system information
  where the number of DIMM slots could be an invalid value
- Fixed a bug preventing the DVD test from starting correctly
  
Release 7.0 build 1015
WIN32 release 19 September 2012
WIN64 release 19 September 2012
- Added a "Ignore "no operations" timeout" option to the plugins 
  so no timeout warnings will be logged
- Changed behaviour so that the test preferences cannot be changed
  if BurnInTest is still collecting system information at startup 
- Changed behaviour so test start time is not recorded until after 
  pre test plugins have finished. Previously the start time was recorded
  when the plugins started and the total test time was applied to them as well
- Fixed a bug in the physical (raw) disk test where the random data with 
  random seeking test could generate an incorrect data verify error
- Fixed a bug where the plugin name could be truncated in the log
- Fixed a case where DirectIO.sys could not be loaded correctly on
  some versions of Windows

Release 7.0 build 1014
WIN32 release 1 August 2012
WIN64 release 1 August 2012
- Made some changes to the plugins test options to allow up to 5
  pre test plugins to be run (PRO only)
- Added a new plugin option to specify whether to run plugins all
  at the same time or on after the other (PRO only)
- Added new plugins to PRO edition (battery capacity, webcam, 
  microphone and sound)

Release 7.0 build 1013
WIN32 release 31 May 2012
WIN64 release 31 May 2012
- Fixed a bug preventing the parallel port test from starting
- Fixed a misplaced newline in the text log output
- Added missing report information (Machine Type, Serial and Notes)
  to text and HTML logs

Release 7.0 build 1012
WIN32 release 8 May 2012
- Corrected a problem where some system information could not be collected on 
  32-bit XP. This problem was introduced in 7.0.1010 - removed System information 
  compatibilty with other PassMark applications.

Release 7.0 build 1011
WIN32 release 26 April 2012
WIN64 release 26 April 2012
- The temperature threshold could be used with the wrong temperature source. 
  This has been corrected.
- Other minor changes.

Release 7.0 build 1010
WIN32 release 4 April 2012
WIN64 release 4 April 2012
- System information updates for Intel and AMD CPUs. 
- Reduced the CPU information collection time on very slow CPUs.
- Workaround for the AMD Llano (12h series) CPU for determining overclocked CPU
  frequencies. Many of these CPUs are meant to have locked multipliers, but 
  in many cases they are not locked and in this case there appears to be a 
  CPU/BIOS issue that leads to the locked CPU frequency being reported, rather 
  than the configured CPU frequency.
- BurnInTest is now compatible with other PassMark applications including 
  PerformanceTest, RamMon and OSForensics. Previously, while monitoring 
  temperature with BurnInTest, some functions, like collecting certain system 
  information, were not available in PerformanceTest etc.
- Spelling corrections.
- Minor help file improvements.
  
Release 7.0 build 1009
WIN32 release 20 February 2012
WIN64 release 20 February 2012
- The CD/DVD burn test did not work on Windows XP. This has been corrected.
- System information updates for AMD CPUs. 

Release 7.0 build 1008
WIN32 release 16 February 2012
WIN64 release 16 February 2012
- System information updates for Intel and AMD CPUs, and AMD GPUs. 
- Temperature monitoring added for newer Intel and AMD CPUs.  
- DirectIO.sys updated to version 9 to resolve a driver verifier issue when 
  collecting SMBIOS data. 

Release 7.0 build 1007
WIN64 release 10 February 2012
- Correction for newer AMD CPU system information (multipliers) when the CPU was 
  loaded by other software.

Release 7.0 build 1006 rev 5
WIN64 release 8 February 2012
- Correction for newer AMD CPU system information (multipliers).
- CPU System information updates.
- Video card System information updates.

Release 7.0 build 1006 rev 4
WIN64 release 1 February 2012
- Correction to the Advanced network test Low NIC Threshold.
- Correction to the BurnInTest temperature monitoring threshold.
- Updated System information for newer Intel CPUs.

Release 7.0 build 1006 rev 3
WIN64 release 27 January 2012
- Correction for the BurnInTest v7.0 SETLOG scripting command (note: the 
  BurnInTest v6.0 SETLOG scripting command works and is unchanged).
- Correction to display the Temperature graph after the test has completed.

Release 7.0 build 1006 rev 2
WIN64 release 21 December 2011
- Updated System information for newer AMD and Intel CPUs.

Release 7.0 build 1006 rev 0
WIN32 release 16 December 2011
- Corrected a bug with the advanced network test error reporting when the test 
  is scripted and when accumulate results is selected.

Release 7.0 build 1005 rev 3
WIN32 release 12 December 2011
WIN64 release 12 December 2011
- PC Test Kit build.

Release 7.0 build 1005 rev 2
WIN32 release 5 December 2011
WIN64 release 5 December 2011
- Added a new command line parameter, -n [minimum volume size in MB], to allow 
  the automatic disk test selection to exclude disk volumes less than a specified 
  size. This could be useful to exclude the System reserved partition on an SSD
  under WinPE.
- Correction to the CPU test if the CPU frequency cannot be detected (very rare 
  bug).
- Minor change to the GPU temperature collection.

Release 7.0 build 1005 rev 1
WIN32 release 1 December 2011
WIN64 release 1 December 2011
- Added System information for newer DDR3 modules (DDR3 SPD version 1.1 detection).
- Corrected a crash bug when collected GPT partition information on a 
  system with more than 1 GPT partition.
- Improved the physical Disk drive system information when used on WinPE. 
- Correction to SSD drive indicator when used on WinPE.
- Corrected a bug where some BurnInTest v4.0 configuration files could not be 
  loaded.
- Minor logging improvements.

Release 7.0 build 1005 rev 0
WIN32 release 21 November 2011
WIN64 release 21 November 2011
- Tuned the memory test allocation when run with the disk test to avoid the 
  disk test running out of memory.

Release 7.0 build 1004 rev 9
WIN32 release 10 November 2011
WIN64 release 10 November 2011
- Corrected a bug where the Preferences->Post test application field didn't 
  work when command line parameters were specified with the application.
- Corrected a problem with the BurnInTest Standard 3D test where on some 
  systems it would not run and would display an DirectX initialization problem. 
  This was not a problem with BurnInTest Pro.
- Corrected a bug where in some cases BurnInTest could report the wrong disk as 
  an SSD.
- Corrected a bug where BurnInTest could incorrectly determine the number of 
  partitions on a raw disk that had previously been tested by the BurnInTest 
  physical disk test. This could cause subsequent physical disk tests on this 
  drive to fail. 
- When starting BurnInTest with the command line parameter to reduce the amount 
  of system information that is collected, -w, the waiting for system 
  information window could still be displayed in some cases. This has been 
  corrected.
- When running on WinPE or Bootable BurnInTest, the physical disks that 
  can be tested are now explicitly restricted to raw disks. Previously this 
  limitation was only documented. 
- Bootable BurnInTest (part of the PC Test Kit and Bootable USB Flash Drive 
  products) does not support the following tests and as such these tests have 
  been greyed out in the Test selection window: 2D, 3D, Video Playback, Sound, 
  Printer and Tape. Previously this limitation was only documented. These 
  limitations do not apply to BurnInTest when run from an installed operating 
  system.
- A very small number of USB drives have been found to cause BurnInTest to hang 
  when collecting disk information. These would appear to be faulty drives. 
  However, as they can cause BurnInTest to hang, especially on starting tests 
  with automatic temperature monitoring on, entering Preferences->Disk or 
  Preferences->Temp, changes have been made to work-around this problem. These 
  changes include the addition of timeout for a range of drive queries and the 
  removal of hot pluggable (USB) drives from the automatic temperature source 
  selection.
- Corrected a bug where in rare cases BurnInTest could crash when Activity level 
  2 trace logging is selected and when BurnInTest reads an event from a very 
  large Windows System or Application event log.
- Tuned the memory test to improve memory allocation on test startup.
- Improved the error location information for writing and reading to a physical 
  disk.   
- Improved BurnInTest software exception handling to produce a mini-dump debug 
  file in more cases.
- Minor logging and documentation changes.

Release 7.0 build 1003 rev 5
WIN32 release 20 October 2011
WIN64 release 20 October 2011
- Corrected the Standard network test preferences for Bad packet ratios.
- Corrected the Advanced network test preferences for Half and Full duplex.
- Corrected the Advanced network test where a disabled IPv6 network interface 
  could be incorrectly displayed in preferences.
- Correct a crash on startup when collecting PCI information on a specific 
  system.
- Change to the 3D font error handling to prevent a crash during the 3D test 
  a particular system.
- Attempt to correct a crash with GPU temperature monitoring.
- Added the raw dump of sound wave samples on certain errors when level 2 
  activity trace logging is selected.
- Improved event logging: remove a duplicate event, moved a trace level event 
  from normal level to level 1 trace event logging, and Plugins can now report 
  an event of severity "NONE".
- Minor improvements to the help file.

Release 7.0 build 1002
WIN32 release 22 September 2011
WIN64 release 22 September 2011
- BurnInTest 7.0 now supports Windows 8 developer preview.
- BurnInTest now uses the PassMark SysInfo SDK to get temperature information.
- The "Collecting system information" progress window was displayed when the 
  "-w" command line parameter was specified (to minimize the amount of system 
  information collected). This has been corrected.
- The "-a" command line parameter has been removed as it does not make sense 
  with BurnInTest 7.0 being run with elevated administrator privileges. 
  Use "-w" to minimize the amount of system information collected.
- BurnInTest could crash on the optical disk test when run with non-PassMark 
  test media, e.g. when run with a DVD video. This has been corrected.
- BurnInTest could crash on startup on a small number of systems when run in 
  debug mode. i.e. only when run with the "-u" command line parameter. This has 
  been corrected.

Release 7.0 build 1001
WIN32 release 14 September 2011
WIN64 release 14 September 2011

NEW TESTS and IMPROVEMENTS TO EXISTING TESTS
Touch screen test:
- BurnInTest now supports the testing of touch screens using the separate 
  PassMark MonitorTest product as a Pre-test plugin. PassMark MonitorTest 
  allows single touch tests and multi touch pan, zoom, rotate and tap 
  gesture tests.

CPU test improvements:
- The number of CPUs (Packages x cores x threads) that can be tested has 
  been increased to 256 (where supported by the Operating System). That is,
  CPUs across multiple processor groups can be tested.
- It is now possible to raise an error on a user defined CPU temperature 
  threshold being exceeded. It is also possible to automatically stop 
  testing in this scenario.
- The duration of the individual CPU tests have been balanced to provide 
  better coverage of some SIMD CPU instructions.
- Improvements to CPU test memory allocation mean memory allocation errors 
  that may have been reported as out of memory CPU errors are now not reported 
  as CPU errors, but more likely as memory errors.

Memory test improvements:
- The memory tests have been optimized to test with higher loads on memory and 
  to run more quickly.
- A new memory adjacency cell test is now included to help detect more memory 
  errors where accessing a memory cell changes the value of an adjacent memory 
  cell. 
- The memory test display has been improved to display write and read speed for 
  the Standard memory test and to not display any previous test results when 
  starting a new test.
- The ability to investigate system issues after an event that crashes BurnInTest 
  (like a driver crashing BurnInTest) has been improved. Specifically, in V6.0 
  the memory test could continue to run if BurnInTest had an unrecoverable 
  error, this could make the system less responsive during post failure 
  investigation.

Disk test improvements:
- Added new disk self tests, short and extended. These are a set of built-in 
  routines implemented by the vendor to perform failure diagnostics on the 
  disk. They can report disk errors such as a failure:
  - of the electrical element,
  - of the servo and/or seek test element,
  - of the read element,
  - due to handling damage.
- SMART monitoring and reporting is now available on many external drives 
  (previously only available on internal drives).
- SMART reporting for disks is now supported when running a physical disk test 
  (previously only available on a disk volume test).
- The physical disk test is now available on formatted disks (that do not 
  contain Windows installations or paging files). In V6.0 the physical disk test 
  was only available on unformatted disks.
- A new disk test mode, Quick physical drive test, is now available for the 
  physical disk test. This tests the most important parts of the physical disk 
  and a random selection of the remainder of the disk. This provides for much 
  quicker disk testing.
- It is now possible to raise an error on a user defined Hard disk temperature 
  threshold being exceeded. It is also possible to automatically stop testing 
  in this scenario.
- Hard disk temperature monitoring is now supported on many external drives 
  (previously only available on internal drives).
- The floppy disk (A:) has been removed from the default disk preference 
  selection.

Standard Network test:
- Changed the Standard Network test to have two types of tests (1) Internal 
  loopback or (2) a test of all available Network ports. The preferences User 
  Interface has been simplified. This overcomes timeouts that could be reported
  with the previous test when "Test all available Network ports" was set to 
  "No".
- Test up to 12 NICs (up from 6).
- Test IPv6 on Windows Vista and later (as well as IPv4). 
- The Standard network test duty cycle load is now more linear (in V6.0 100% 
  duty cycle was significantly higher load than 99%).
- The default timeout has been increased from 2 seconds to 4 seconds.

Advanced Network test:
- Test up to 12 NICs (up from 6).
- Select to test from up to 20 local NICs (up from 10).
- Test can now test IPv6 on Windows Vista and later (as well as IPv4). 
  Note: BurnInTest and the Endpoints must support IPv4.
- The test window now displays all of the NICs being tested and it’s Endpoint.
- The test preferences now includes a Display Endpoints option to make it 
  clearer the number of endpoints currently available for testing.
- A low throughput threshold value can now be specified to raise a throughput 
  error.

Optical drive test improvements:
- The Optical disk configuration file is now portable across systems where the 
  optical drive configuration is different. 
- The number of Optical drive tests has been increased from 20 to 26.
- If Select all available drives is selected and the automatic detection of 
  optical drives determines there are no drives, then the optical drive test is 
  turned off.

2D test improvements:
- 2D video memory test cycle count definition has been changed so that 1 cycle 
  represents 1 full pass of the video test memory.

USB test improvements:
- Test up to 25 USB ports with the PassMark USB 2.0 Loopback plug (up from 10). 
  This also requires V7.0 of the USB 2.0 Loopback plug device driver.
- A new option to auto detect the number of USB plugs connected has been added. 
  There must be at least 1 plug for the test.
- The PassMark USB 2.0 Loopback plug is now compatible with other USB products 
  from other vendors. BurnInTest 7.0 supports USB testing when these other USB 
  devices are connected. Specifically, a 3rd party USB device uses the same 
  internal name as the USB 2.0 Loopback plug (with V6.1 of the device driver and 
  earlier) which meant that that USB device needed to be removed before USB 
  testing could be conducted with BurnInTest.

Sound Loopback test:
- Changed the Sound loopback test mechanism to use longer sampling durations. 
  This resolves a problem where the test could report false positives when the 
  CPU is under heavy load.

Serial Port test:
- The BurnInTest serial port test has been changed to configure the COM ports when
  run from Microsoft WinPE 3.0 so that the COM ports can be tested.

Video Playback test:
- Added a default test video file (300x168) for Video Playback if no other video 
  files are available or selected.

Temperature:
- A new Temperature tab has been added to allow the monitoring of temperature 
  over the test period. 
- Temperature can be monitored and reported for 6 temperature sources 
  (up from 3).
- Temperature can now be graphed for 6 temperature sources.
- Temperature sources can now be automatically selected by BurnInTest.
- Temperature can be monitored and reported for some nVIDIA and AMD GPUs (as 
  well as CPU and Hard disks).
- Temperature reporting included for new AMD CPUs (APUs).
- Temperature monitoring for Intel Core 2 CPUs (as well as later Intel CPUs).
- The final test temperatures are now displayed after the test has completed 
  (and reset on start of tests).
- The frequency temperature values that are to be sampled can now be specified. 
  The sampling now occurs regardless of which tab is displayed (previously the 
  Results tab needed to be displayed).
- It is now possible to raise an error on a user defined CPU, hard disk and GPU 
  temperature threshold being exceeded. It is also possible to automatically 
  stop testing in this scenario.
- Hard disk temperature monitoring is now supported on many external drives 
  (previously only available on internal drives).
- Selecting the Maximum CPU temperature as a Quicktest no longer turns off 
  temperature monitoring.
- Changed the CPU Quicktests to monitor CPU temperature only (if available). 
  Changed the 2D and 3D Quicktests to monitor GPU temperature (if available). 
  Changed the Disk Quicktests to monitor Disk temperature (if available)
- Changed the temperature preferences to validate temperature values for disks
  before allowing them to be selected.

AUTOMATION
- Scripting has been extended to allow many common preference settings to be 
  set. Specifically, the following new scripting commands have been added:
  - SETCPU
  - SETDISK
  - SETDEFAULTPREFERENCES
  - SETERRORS
  - SETNETWORK
  - SETOPTICALDISK
  - SETPRETEST
  - SETPOSTTEST
  - SETRAM
  - SETSERIALPORTS
  - SETPARALLELPORTS
  - SETSOUND
  - SETUSB
  - SETVIDEOPLAYBACK
  - SET2DGRAPHICS
  - SETLOG (options have been expanded)
- BurnInTest can now be signaled to stop (and exit) by an external application. 
- If a script file does not exist in the My Documents directory and no path is 
  specified an error message is now displayed.
- The Pre-test, launch application and don't wait now uses the default directory 
  (like the wait version) for configuration and scripting.
- Documented a command line parameter to set the screen resolution on starting 
  BurnInTest, intended for use with Microsoft WinPE.
 
NEW SYSTEM INFORMATION
- Updates for newer CPU and GPU models.
- Improved maximum CPU speed measurement.
- Improved the RAM module information that is displayed and reported. Detailed 
  RAM SPD module information is now available with trace file logging.
- System information summary now displays SSD's separately from HDD's.
- System information now displays USB 3.0 host controllers and the devices on 
  the hubs behind these host controllers.
- In the case that 2 GPUs from different vendors were installed, it was possible 
  that the description for one of these was incorrect. This has been changed.
- When BurnInTest is run on WinPE 3.x, BurnInTest did not report the COM ports 
  in the System Information section. This has been changed.
- Corrected the Video Card chip type description where gibberish could be 
  displayed after the description string.
 
REPORTING
- More than one report type can now be automatically saved, i.e. text, HTML and 
  the customer certificate can now all be selected.
- The trace file format can now be selected (rather than being the same format 
  as the main report file). Specifically if the report is HTML, the trace file 
  can be text (which is easier to analyze).
- Increased the length of report event lines from 100 characters to 200 
  characters. In particular the report line length was previously truncated for 
  some customer Plugins and Windows systems events.
- Changed the Logging Preferences, Clear results and append to existing log 
  file, option (which was creating a new log file for each test run).
- Copying text or HTML to the Clipboard will now copy both formats to the 
  clipboard such that a subsequent paste will be either text or HTML, 
  depending on the application.

GENERAL
- Improved support for not Latin (e.g. English) character sets. While BurnInTest 
  is in English, some information collected from the system or entered by the 
  user may now use non-Latin character sets.
- BurnInTest has been changed to run with elevated administrator privileges as 
  this is required for some tests and quite a lot of system information. This 
  also allows temperature monitoring to be turned on by default.
- The "FAIL" definition has been changed to include critical, serious and warning 
  events, but now exclude information level events.
- All events may now be configured to not be reported if they are not meaningful 
  in a specific test environment (by setting to NONE in 
  BITErrorClassifications.txt).
- A "preferences editor" mode has been added to create test configurations for 
  just about any system, without needing the hardware (e.g. configure hard disk 
  to be tested that are not on the local system).
  Specifically, when specifying the command line parameter "Y": 
  - All HDD drive letters [A..Z] and physical disk numbers [0..99] are displayed 
    and allowed in Preferences->Disk; 
  - all optical disk drive letters [A..Z] are added to Preferences->Disk; 
  - CPU instructions not supported on the current system, are selectable. 
  - Files are not validated for existence: Plugin, sound, logging, video 
    playback, pre/ post test.
- Improved the look of the Event log window, making it easier to review the 
  events. This includes:
  - The removal of the limit of displaying 1000 events.
  - Sorting of events based on their severity, time, source and description.
  - A contextual popup menu for clearing results and copying events to the 
    clipboard.
  - Double clicking an event will now display a description of the common 
    errors.
- Improved the look of the Result log window, making it easier to review the 
  results. This includes:
  - Sorting of events based on their test name, cycles, operations, errors
    and last error description.
  - A contextual popup menu for clearing results and copying events to the 
    clipboard.
- Reduced the start-up time on newer Intel CPUs.
- Changed the Disk, Optical drive and USB preference windows for consistency.
- The retry timeouts for some error types has been standardized.
- Removed a directory does not exist warning message from Preferences->Logging 
  when the directory of the log file is the root directory of a drive.
- Changed the internal handling of the Windows 2D GUI test such that it is 
  de-linked from the main BurnInTest Window and the main Window can now be 
  moved while this test is running.
- Changed the definition of Cycles for the 3D, Network, Video Playback and USB 
  tests to better balance the cycle count across tests.
- Add launch of cmd.exe option from BIT menu when running in WinPE.
- Other minor improvements and bug corrections.
- Help updates.


History of earlier releases:
Please see http://passmark.com/products/bit_history.htm


Documentation
=============
All the documentation is included in the help file. It can be accessed from
the help menu. There is also a PDF format Users guide available for download 
from the PassMark web site.


Support
=======
For technical support, questions, suggestions, please check the help file for 
our email address or visit our web page at http://www.passmark.com


Ordering / Registration
=======================
All the details are in the help file documentation
or you can visit our sales information page
http://www.passmark.com/sales


Compatibility issues with the Network and Parallel Port Tests
===========================================================
If you are running Windows 2000 or Windows XP, you need to have 
administrator privileges to run this test.


Enjoy..
The PassMark Development team