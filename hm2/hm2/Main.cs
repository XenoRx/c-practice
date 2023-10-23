using hm2;
using Xunit;

// Создаем объект Bits из long
long value = 1234567890;
Bits bits = value;

// Проверяем, что массив байтов объекта Bits содержит ожидаемые значения
byte[] bytes = bits.Data;
bytes[0] = 0x00;
Assert.Equal(bytes[0], 0x00);

// Создаем объект Bits из int
int value2 = 12345;
Bits bits2 = value2;

// Проверяем, что массив байтов объекта Bits содержит ожидаемые значения
bytes = bits2.Data;
bytes[0] = 0x00;
Assert.Equal(bytes[0], 0x00);

// Создаем объект Bits из byte
byte value3 = 127;
Bits bits3 = value3;

// Проверяем, что массив байтов объекта Bits содержит ожидаемые значения
bytes = bits3.Data;
bytes[0] = 0x7f;
Assert.Equal(bytes[0], 0x7f);