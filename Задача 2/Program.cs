Console.WriteLine( "введите количество строк" );
int lines = Convert.ToInt32( Console.ReadLine() );

Console.WriteLine( "введите количество столбцов" );
int columns = Convert.ToInt32( Console.ReadLine() );

Console.WriteLine("рандомное число с ");
int randomVal1 = Convert.ToInt32( Console.ReadLine() );

Console.WriteLine( "рандомное число по" );
int randonVal2 = Convert.ToInt32( Console.ReadLine() );

int[,] numbers = new int[ lines, columns ];

FillArrayRandomNumbers( numbers );

Console.WriteLine();
Console.WriteLine( "Массив до изменения" );

PrintArray( numbers );

if ( lines != columns )
{
  Console.WriteLine( "Массив не квадратный, невозможно заменить строки на столбцы!" );  
}
else 
{
 for( int i = 0; i < numbers.GetLength( 0 ); ++i ) 
 {
     for( int j = i  +1; j < numbers.GetLength( 0 ); ++j ) 
     {
          int temp = numbers[ i, j ];
          numbers[ i, j ] = numbers[ j, i ];
          numbers[ j, i ] = temp;
     }
}
Console.WriteLine ("Массив с заменой строк на столбцы" );
PrintArray( numbers );
Console.ReadLine();
}

void FillArrayRandomNumbers( int[,] arr )
{
    for ( int i = 0; i < arr.GetLength( 0 ); ++i )
    {
        for ( int j = 0; j < arr.GetLength( 1 ); ++j )
        {
            arr[ i, j ] = new Random().Next( randomVal1, randonVal2 );
        }
    }
}

void PrintArray( int[,] arr )
{
    for ( int i = 0; i < arr.GetLength( 0 ); ++i )
    {
        for ( int j = 0; j < arr.GetLength( 1 ); ++j )
        {
            Console.Write( arr[ i, j ] + " " );
        }
        Console.WriteLine( "" );
    }
}