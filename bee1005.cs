using System;

class URI {

static void Main(string[] args) { 

 double NOTAPESO1,NOTAPESO2,MEDIA;

 NOTAPESO1 = Convert.ToDouble(Console.ReadLine());
 NOTAPESO2 = Convert.ToDouble(Console.ReadLine());

 Console.WriteLine("MEDIA = " + ((NOTAPESO1*3.5 + NOTAPESO2*7.5)/(3.5+7.5)).ToString("0.00000"));

}
}
