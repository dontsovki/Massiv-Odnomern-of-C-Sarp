//функция преобразования числового массива в строку

int main() // функция преобразования числового массива в строку
{
int size = 15;
int digits[size] = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 2, 3, 0, 4};
std::string result = "";

for (int i = 0; i < size; i++)
{
if (!(digits[i] == 0 && result.size() == 0))
result += std::to_string(digits[i]);
}

std::cout << result << std::endl;
}