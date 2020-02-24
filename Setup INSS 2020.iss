; Script generated by the Inno Script Studio Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "Calculadora INSS 2020"
#define MyAppVersion "1.0"
#define MyAppPublisher "Maycon Wisley"
#define MyAppExeName "CalculadoraINSS2020WF.exe"

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{07A2E526-B929-48C2-8679-4F63153BBCA5}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
DefaultDirName={pf}\{#MyAppName}
DefaultGroupName={#MyAppName}
OutputDir=D:\Programacao\slnCalculadoraINSS2020WF\CalculadoraINSS2020WF\bin
OutputBaseFilename=Calculadora INSS 2020
SetupIconFile=D:\Programacao\slnCalculadoraINSS2020WF\Icones\favicon.ico
Compression=lzma
SolidCompression=yes

[Languages]
Name: "brazilianportuguese"; MessagesFile: "compiler:Languages\BrazilianPortuguese.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"

[Files]
Source: "D:\Programacao\slnCalculadoraINSS2020WF\CalculadoraINSS2020WF\bin\x86\Release\CalculadoraINSS2020WF.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Programacao\slnCalculadoraINSS2020WF\CalculadoraINSS2020WF\bin\x86\Release\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{group}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{group}\{cm:UninstallProgram,{#MyAppName}}"; Filename: "{uninstallexe}"
Name: "{commondesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Flags: nowait postinstall skipifsilent; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Tasks: desktopicon
