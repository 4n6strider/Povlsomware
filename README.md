# Povlsomware
Povlsomware is a Ransomware Proof-of-Concept created as a "secure" way to test anti-virus vendors claims of *"Ransomware Protection"*. Povlsomware does not destroy the system nor does it have any way of spreading to any network-connected computer and/or removable devices.

![alt text](https://raw.githubusercontent.com/povlteksttv/Povlsomware/master/img/first.png?raw=true)


## How does it work?
Povlsomware works as a single exectuable, that when executed will perform the following steps: 
1) Povlsomware will go through the file system looking for personal files with certain extensions (i.e. jpeg, png, docx, txt, xls etc.).
2) Files matching the list of extensions will be encrypted using AES256 with the password "blahblah" (This can be changed in the program.cs-file).
3) It will delete every shadowcopy on the affected system, if Povlsomware has been executed with Administrative rights. 
4) A "ransom pop-up UI" is shown informing the user, how many files have been encrypted. The pop-up also contains a password-field, which allows for decrypting the files.
