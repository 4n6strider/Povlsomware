# Povlsomware
Povlsomware is a Ransomware Proof-of-Concept created as a "secure" way to test anti-virus vendors claims regarding "Ransomware Protection". The executable does not attempt to destroy the system nor does it have any way of spreading to any network-connected computer and removable devices.

![alt text](https://raw.githubusercontent.com/povlteksttv/Povlsomware/master/img/first.png?raw=true)


## How does it work?
Povlsomware works as a single exectuable, that when executed will perform the following steps: 
1) Go through the entire file system looking for files with certain extension (i.e. jpeg, png, docx, txt, xls etc.)
  - It will not go through C:\Windows
2) 
