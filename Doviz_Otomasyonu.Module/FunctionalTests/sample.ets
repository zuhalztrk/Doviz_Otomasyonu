;#DropDB Doviz_OtomasyonuEasyTest

#Application Doviz_OtomasyonuWin
#Application Doviz_OtomasyonuBlazor

*FillForm
 User Name = Admin
*Action Log In

#IfDef Doviz_OtomasyonuWin

*Action About...
 
*Action OK

#EndIf

#IfDef Doviz_OtomasyonuBlazor
*Action Navigation(My Details)
#EndIf
