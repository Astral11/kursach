Run("C:\KURSGAME\2Dgame0.2.exe")
WinWaitActive("2DPlatformer Configuration")

Local $MenuXY = WinGetPos("2DPlatformer Configuration")
Local $CurrentMenuX = $MenuXY[0] + 327
Local $CurrentMenuY = $MenuXY[1] + 415
MouseClick("left",$CurrentMenuX,$CurrentMenuY,1)

WinWaitActive("2DPlatformer")
Local $GameXY= WinGetPos("2DPlatformer")
Sleep(5000)
MouseClick("left",$GameXY[0]+100,$GameXY[1]+100)


Opt("SendKeyDownDelay",5000)
AutoItSetOption("SendKeyDelay",0)
Send("D")

Opt("SendKeyDownDelay",0)
Send("{SPACE}")
Sleep(1500)
Send("{SPACE}")
Sleep(1500)
Opt("SendKeyDownDelay",2000)
Send("A")
Opt("SendKeyDownDelay",0)
Send("{LCTRL}")
Sleep(300)
Send("{LCTRL}")
Sleep(300)
Send("{LCTRL}")
Sleep(300)
Send("{LCTRL}")
Send("D")
Sleep(300)
Send("{LCTRL}")
Sleep(300)
Send("{LCTRL}")
Sleep(300)
Send("{LCTRL}")
Opt("SendKeyDownDelay",5000)
Send("A")