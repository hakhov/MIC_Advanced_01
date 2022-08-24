
Console.WriteLine(Factorial(5)); //120
//Մեթոդների կիրառմամբ ստեղծել զանգվածի ստացման ավտոմատ և մանուալ տարբերակներ։
//Գտնել Max, Min, Sum, Prime, Sort գաղափարները։ Ինչպես նաև տպելու տարբեր հնարավորույթուններ։

static int Factorial(int a)//5!=5*(5-1)*(5-2)*(5-3)*(5-4)//(5-5)
{
    //if (a == 1)
    //{
    //    return 1;
    //}

    //if (a == 2)
    //{
    //    return 2;
    //}

    if (a == 1)
    {
        return 1;
    }
    return a * Factorial(a - 1);
}
