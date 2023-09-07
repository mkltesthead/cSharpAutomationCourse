download certificates from website and place in C:\dev\SDET\cSharpAutomationCourse\noel-code\IntroPlaywright\PlaywrightCerts

using Powershell add each certificate to cacert.pem
gc "C:\dev\SDET\cSharpAutomationCourse\noel-code\IntroPlaywright\PlaywrightCerts\_.azureedge.net.crt" | ac "C:\dev\SDET\cSharpAutomationCourse\noel-code\IntroPlaywright\PlaywrightCerts\cacert.pem"
gc "C:\dev\SDET\cSharpAutomationCourse\noel-code\IntroPlaywright\PlaywrightCerts\chid1.crt" | ac "C:\dev\SDET\cSharpAutomationCourse\noel-code\IntroPlaywright\PlaywrightCerts\cacert.pem"
gc "C:\dev\SDET\cSharpAutomationCourse\noel-code\IntroPlaywright\PlaywrightCerts\chid2.crt" | ac "C:\dev\SDET\cSharpAutomationCourse\noel-code\IntroPlaywright\PlaywrightCerts\cacert.pem"
gc "C:\dev\SDET\cSharpAutomationCourse\noel-code\IntroPlaywright\PlaywrightCerts\Zscaler Root CA.crt" | ac "C:\dev\SDET\cSharpAutomationCourse\noel-code\IntroPlaywright\PlaywrightCerts\cacert.pem"

using Powershell process cacert.pem
$env:NODE_EXTRA_CA_CERTS = 'C:\dev\SDET\cSharpAutomationCourse\noel-code\IntroPlaywright\PlaywrightCerts\cacert.pem'

install all browsers
C:\dev\SDET\cSharpAutomationCourse\noel-code\IntroPlaywright\PlaywrightMSTest\bin\Debug\net7.0> .\playwright.ps1 install