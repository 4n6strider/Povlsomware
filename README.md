# Povlsomware
Povlsomware is a Ransomware Proof-of-Concept created as a "secure" way to test anti-virus vendors claims of *"Ransomware Protection"*. Povlsomware does not destroy the system nor does it have any way of spreading to any network-connected computer and/or removable devices.

![alt text](https://raw.githubusercontent.com/povlteksttv/Povlsomware/master/img/first.png?raw=true)


## How does it work?
Povlsomware works as a single exectuable, that when executed will perform the following steps: 
1) Povlsomware will go through the file system looking for personal files with certain extensions (i.e. jpeg, png, docx, txt, xls etc.).
2) Files matching the list of extensions will be encrypted using AES256 with the password "blahblah" (This can be changed in the program.cs-file).
3) It will delete every shadowcopy on the affected system, if Povlsomware has been executed with Administrative rights. 
4) A "ransom pop-up UI" is shown informing the user, how many files have been encrypted. The pop-up also contains a password-field, which allows for decrypting the files.


## Extensionless Ransomware
Many ransomware programs will encrypt files and change the original file extension to something like .Krab, .ppam, .trumphead. etc. The reason why most ransomware programs changes file extensions is so that they know which files to decrypt (if necessary). Povlsomware differs from most ransomware by keeping the original file extension. The files will thus look the same, however none of them will work as intended. 

For a comprehensive list of ransomware extensions, see Comondos "Ransomware Extension List": https://enterprise.comodo.com/ransomware-extension-list.php. 


## Cobaltstrike integration 
Povlsomware.exe can be executed in memory using Cobaltstrikes "Execute-Assembly" command. The screenshot below is an example of this:

![alt text](https://raw.githubusercontent.com/povlteksttv/Povlsomware/master/img/execute-assembly.PNG?raw=true)  

The perfect thing about this, is that Povlsomware.exe is not needed on the victim-PC, but can be executed directly in memory from the attacker. 

More than that, Povlsomware is programmed to communicate back to the Cobaltstrike Teamserver, which files have been encrypted in the process. If the decryption password is entered, Povlsomware will communicate the decrypted files.

![alt text](https://raw.githubusercontent.com/povlteksttv/Povlsomware/master/img/output.PNG?raw=true)  
