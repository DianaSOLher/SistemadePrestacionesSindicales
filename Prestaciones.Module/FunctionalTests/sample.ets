;#DropDB PrestacionesEasyTest

#Application PrestacionesWin
;#Application PrestacionesWeb

*FillForm
 User Name = Admin
*Action Log In

#IfDef PrestacionesWin

*Action About...
 
*Action OK

#EndIf

#IfDef PrestacionesWeb
*Action Navigation(My Details)
#EndIf
