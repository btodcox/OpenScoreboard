# Scoreboard code

* Host PC code is written in C# and is provided as a Visual Studio project.
* Moteino code compiles with the standard Arduino Development Environment.
    * Installation of appropriate libraries from lowpowerlabs github respositories is required.

* Preliminaries for Moteinos:
	* Clear eeprom on each Moteino used for lane displays
	* Program location 0 of eeprom with "address" of lane for Moteinos for each lane
    	* Address 0 is event/heat display
    	* Addresses 1-10 are Lanes 1-10, respectively
	* Base code goes on USB Moteino
	* RemoteHEWP code goes on Moteinos for each lane

## Programming the Moteinos in Scoreboard

* After initial programming of Moteinos with RemoteHEWP program, it is possible to wirelessly program them Moteinos WITHOUT disassembling the Scoreboard.  
* Wireless programming requires that a SPIFlash be installed on all Moteinos in the Scoreboard.
* More information about wireless programming is available at [lowpowerlabs.com](http://lowpowerlab.com/blog/category/moteino/wireless-programming/).




     