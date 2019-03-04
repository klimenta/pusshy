# pusshy
A simple GUI front-end for OpenSSH on Windows 10

# What is pusshy?
pusshy is not a replacement for putty. pusshy is a simple GUI front-end for OpenSSH on Windows 10. 
As of late 2018, OpenSSH comes as default in Windows 10 but it lacks front-end like putty. 
So, pusshy tries to cross that bridge with this simple .NET program.

# Pre-requisites

* OpenSSH installed under C:\WINDOWS\SYSTEM32\OPENSSH
* .NET 4.5

# How does it work?
When you start pusshy, you can enter the SSH host, the login that you want to use, the password, the certificate (in case you use certificates) and a description for your connection. OpenSSH do not use passwords to log you automatically, so you can omit the password if you want. You have to enter it anyway when you log in. The password column is for your reference only. You can still copy and paste it in the OpenSSH session if you want. By default, when you select the password column, the password will be visible. 

The certificate file is used when your SSH server uses certificates instead of passwords (e.g. an AWS Linux server).  In this case, if you have a username and certificate file specified, you'll be logged automatically. 

If you right-click on a column, you can hide it. If you want the column to be shown again, right-click anywhere in the header and choose Show All. 

If you right-click on a row header, you can delete an entry. Multiple selections are allowed too.

Any changes you make will be saved when the program is closed. 
The program does remember the size and the position of the application, so next time you start the program, the size and the position will be the same as when you closed it. 

All the setting are saved under **C:\users\<username>\AppData\Local\pusshy** folder. 

Double-click top start a new session. Single-click to edit a cell.

![Screenshot](https://user-images.githubusercontent.com/7636104/53757607-1594e800-3e8a-11e9-9850-efbe1f6880b4.PNG)

