dim PLMShare, PLM_ShortCut, PLM_Bin, PLM_Icon 

'____________________________
' PLMShare
Set oShell = CreateObject( "WScript.Shell" )
'PLMShare = oShell.ExpandEnvironmentStrings("%PLMSHARE%")
'PLMShare = "\\TC-TST02\PLMShare"
PLMShare = "\\TC-PROD02\PLMShare"
PLM_ShortCut = PLMShare & "\" & "PLM_Startup\Startups"
PLM_Bin      = PLMShare & "\" & "PLM_Startup\Startups\bin"
PLM_Icon     = PLMShare & "\" & "PLM_Startup\Startups\icons"


'____________________________
' SWIM Launch
dim SW_Select(3)
SW_Select(0) = PLM_ShortCut & "\" & "KMWE - SolidWorks SWIM.lnk"
SW_Select(1) = PLM_Bin & "\" & "SolidWorks_SWIM.exe"
SW_Select(2) = ""
SW_Select(3) = PLM_Icon & "\" & "swim.ico,0"

CreateShortCut(SW_Select)


function CreateShortCut (Data())
	Set objShell = WScript.CreateObject("WScript.Shell")
	Set lnk = objShell.CreateShortcut(Data(0))
	
	lnk.TargetPath = Data(1)
	lnk.Arguments = Data(2)
	lnk.IconLocation = Data(3)
	lnk.WindowStyle = "1"
	lnk.WorkingDirectory = "%TEMP%"
	lnk.Save
	
	'Clean up 
	Set lnk = Nothing
end function

