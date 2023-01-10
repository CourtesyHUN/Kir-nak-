o=input("Kérem az összeget: ")
o=int(o)
he=o//20000
o=o%20000
te=o//10000
o=o%10000
oe=o//5000
o=o%5000
ke=o//2000
o=o%2000
e=o//1000
o=o%1000
osz=o//500
o=o%500
ksz=o//200
o=o%200
sz=o//100
o=o%100
otven=o//50
o=o%50
h=o//20
o=o%20
t=o//10
o=o%10
ot=o//5
o=o%5
print(he,"db 20000Ft-os")
print(te,"db 10000Ft-os")
print(oe,"db 5000Ft-os")
print(ke,"db 2000Ft-os")
print(e,"db 1000Ft-os")
print(osz,"db 500Ft-os")
print(ksz,"db 200Ft-os")
print(sz,"db 100Ft-os")
print(otven,"db 50Ft-os")
print(h,"db 20Ft-os")
print(t,"db 10Ft-os")
print(ot,"db 5Ft-os")