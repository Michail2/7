Console.WriteLine( "введите количество строк" );
int lines = Convert.ToInt32( Console.ReadLine() );

Console.WriteLine( "введите количество столбцов" );
int columns = Convert.ToInt32( Console.ReadLine() );

Console.WriteLine( "рандомное число с " );
int randomVal1 = Convert.ToInt32( Console.ReadLine() );

Console.WriteLine("рандомное число по");
int randonVal2 = Convert.ToInt32( Console.ReadLine() );

int[,] numbers = new int[ lines, columns ];

FillArrayRandomNumbers( numbers );

Console.WriteLine();
Console.WriteLine( "Массив до изменения" );

PrintArray( numbers );

for ( int i = 0; i < numbers.GetLength( 0 ); ++i )
{
    for ( int j = 0; j < numbers.GetLength( 1 ) - 1; ++j )
    {
        for ( int z = 0; z < numbers.GetLength( 1 ) - 1; ++z )
        {
            if ( numbers[ i, z ] < numbers[ i, z + 1 ] ) 
            {
                int temp = 0;
                temp = numbers[ i, z ];
                numbers[ i, z ] = numbers[ i, z + 1 ];
                numbers[ i, z + 1 ] = temp;
            }
        }
    }
}
Console.WriteLine();
Console.WriteLine( "Массив с упорядоченными значениями" );
PrintArray( numbers );

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
