t=input("A munkaideje másodpercben: ")
t=int(t)
ora = t//3600
perc = (t%3600)//60
mperc = t%60
print ("A munkaidő ", ora," óra ", perc, " perc ", mperc, " másodperc " )