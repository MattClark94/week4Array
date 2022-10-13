string[,] addressBook = new string[10,2]; 


for (int i=0; i<10; i++)
{ 
    Console.WriteLine("Enter Name"); 
    addressBook[i,0] = Console.ReadLine(); 
    Console.WriteLine("Enter Address"); 
    addressBook[i,1] = Console.ReadLine();  
}

Console.WriteLine("Name       |           Address")


Console.ReadKey(); 