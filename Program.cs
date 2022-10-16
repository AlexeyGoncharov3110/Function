int Max (int arg1, int arg2, int arg3)
{
int result= arg1;
if(arg2>result) result = arg2;
if(arg3>result) result = arg3;
return result;
}
int a1 = 12;
int b1 = 22;
int c1 = 42;
int a2 = 2551;
int b2 = 321;
int c2 = 45;
int a3 = 18;
int b3 = 44;
int c3 = 56;
int max = Max(Max(a1,b1,c1),Max(a2,b2,c2),Max(a3,b3,c3));
Console.WriteLine(max);
