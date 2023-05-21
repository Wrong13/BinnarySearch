// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int BinnarySearch(int[] list, int item)
{
    int low = 0;                //Начало поиска
    int hight = list.Length;    // Конец поиска
    int mid;                    // Середина
    int rezult = 0;             
    while (low <= hight)
    {
        mid = (low + hight) / 2;
        rezult = list[mid];
        if (rezult == item)     // Нашли
            return mid;
        if (rezult > item)      // Полученное больше чем искомое сокращаем массив на 2 
            hight = mid - 1;    // Оставляем левую половину
        else
            low = mid + 1;      // Меньше, следовательно оставляем правую половину
    }
    return 404;                 // Если нету (типо ошибка 404)
}

int[] mylist = new int[] {1,3,5,7,9,30};


Console.WriteLine(BinnarySearch(mylist,1));
Console.WriteLine(BinnarySearch(new int[] {4,6,7,10,32,40,99},99));