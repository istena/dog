Console.Clear();
int Newint(){
int Leght=int.Parse(Console.ReadLine());
return Leght;
}
int NewDistance(int speeddod,int speed1,int speed2, int distance,int count){
 int dis=0;
   if (count%2==0){
     dis=distance-(speed1*distance)/(speed2+speeddod);
   }
    else {
        dis=distance-(speed2*distance)/(speed1+speeddod);
    }
    return dis;
}
Console.Write("Введите дистанцию между людьми = ");
int Distance=Newint();
Console.Write("Введите скорость первого = ");
int Speed1=Newint();
Console.Write("Введите скорость второго = ");
int Speed2=Newint();
Console.Write("Введите скорость собаки = ");
int Speeddog=Newint();
int Count=0;
while(Distance>10){
    Distance=NewDistance(Speeddog,Speed1,Speed2,Distance,Count);
Count++;
}
Console.Write($"Собака пробежала {Count} раз");


