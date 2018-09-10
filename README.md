# Mscordacwks Collector

Did you ever grab a crash dump from a customer's machine and you were not able
to analyze it in WinDbg, because you didn't have the matching mscordacwks.dll
and SOS.dll? Until you recognize the mistake lies in the missing files, the
customer has installed an update or reset the machine?

Never have this sort of trouble again with the Mscordacwks / SOS collector
application. It scans the PC for those DLLs, copies them into a directory
of your choice and renames them according their version number.

The program will look in
* .NET framework 2.0 folder
* .NET framework 4.0 folder
* SXS folders


# Source Code

Original source code from https://debugging.wellisolutions.de/download-mscordacwks-collector/

SVN URL: http://opensource.svn.wellisolutions.de/MscordacwksCollector/  
Username: guest  
Password: debugging


# License

Free for personal and commercial use  
Copyright (c) 2014 Thomas Weller
