Console.WriteLine( "введите количество строк" );
int lines = Convert.ToInt32( Console.ReadLine() );

Console.WriteLine( "введите количество столбцов" );
int columns = Convert.ToInt32( Console.ReadLine() );

Console.WriteLine( "рандомное число с " );
int randomVal1 = Convert.ToInt32( Console.ReadLine() );

Console.WriteLine( "рандомное число по" );
int randonVal2 = Convert.ToInt32(Console.ReadLine() );

int[,] numbers = new int[ lines, columns ];

FillArrayRandomNumbers( numbers );

PrintArray( numbers );

int minsum = Int32.MaxValue;
int indexLine = 0;

for ( int i = 0; i < numbers.GetLength( 0 ); ++i )
{
    int sum = 0;
    for ( int j = 0; j < numbers.GetLength( 1 ); ++j )
    {
        sum = sum + numbers[ i, j ];        
    }
    if ( sum < minsum )
    {
        minsum = sum;
        indexLine++;
    }
}

Console.WriteLine( "строка с наименьшей суммой елементов под номером: " + ( indexLine ) + ", с суммой елементов равной: " + ( minsum ) );

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
