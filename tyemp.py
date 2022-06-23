import math;

def doinputoutput():

    tempF = int(input('enter a number: '))

    windspeed = int(input('enter another number:'))

    windchillnumber = windchill(tempF, windspeed)
    
    print(windchillnumber)

def windchill(tempF, windspeed):

    windchill_equation = 35.74 + 0.6215 * tempF - 35.75 * windspeed**0.16 + 0.4275 * tempF * windspeed**0.16
    return windchill_equation


doinputoutput()
