string[] array = { "hello", "2", "world", ":-0"};
int number = 4;

array = array.Where(e => e.Length < number).ToArray();

for (int i = 0; i < array.Length; i++){
    Console.WriteLine(array[i]);
}