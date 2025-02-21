# oscript-compressor

Библиотека сжатия данных для OneScript, включающая алгоритмы **LZ4**, **Snappy**, **Zstd**, **Brotli**, **GZip**, **ZLib** и **Deflate**. 

Реализовано с использованием .NET библиотек [EasyCompressor](https://github.com/mjebrahimi/EasyCompressor/) и [BrotliSharpLib](https://github.com/master131/BrotliSharpLib).

## Установка

```
opm install compressor
```

## Использование

[Описание программного интерфейса](docs/README.md)

``` bsl
#Использовать compressor

// Примеры упаковки данных
Процедура Упаковать()

  Компрессор = Новый GZipКомпрессор();

  // 1. Сжимаем двоичные данные
  УпакованныеДанные = Компрессор.Упаковать(ДвоичныеДанные);
  
  // 2. Сжимаем двоичные данные в исходящий поток
  Компрессор.Упаковать(ДвоичныеДанные, ИсходящийПоток);
  
  // 3. Читаем входящий поток и сжимаем в исходящий поток
  Компрессор.Упаковать(ВходящийПоток, ИсходящийПоток);
  
  // 4. Читаем входящий поток и возвращаем сжатые двоичные данные 
  УпакованныеДанные = Компрессор.Упаковать(ВходящийПоток);

КонецПроцедуры

// Примеры распаковки данных
Процедура Распаковать()

  Компрессор = Новый GZipКомпрессор();

  // 1. Распаковываем двоичные данные
  РаспакованныеДанные = Компрессор.Распаковать(ДвоичныеДанные);
  
  // 2. Распаковываем двоичные данные в исходящий поток
  Компрессор.Распаковать(ДвоичныеДанные, ИсходящийПоток);
  
  // 3. Читаем входящий поток и распаковывем в исходящий поток
  Компрессор.Распаковать(ВходящийПоток, ИсходящийПоток);
  
  // 4. Читаем входящий поток и возвращаем распакованные двоичные данные
  РаспакованныеДанные = Компрессор.Распаковать(ВходящийПоток);

КонецПроцедуры
```

## Совместимость

<table>
  <thead>
    <tr>
      <th colspan="2">Windows</th>
      <th colspan="2">Linux</th>
      <th colspan="2">MacOS</th>
    </tr>
    <tr>
      <th>OneScript 1.9</th>
      <th>OneScript 2.0</th>
      <th>OneScript 1.9</th>
      <th>OneScript 2.0</th>
      <th>OneScript 1.9</th>
      <th>OneScript 2.0</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <td align="center">✅</td>
      <td align="center">✅</td>
      <td align="center">✅</td>
      <td align="center">✅</td>
      <td align="center">❓</td>
      <td align="center">❓</td>
    </tr>
  </tbody>
</table>

## Библиотеки алгоритмов

<table>
  <thead>
    <tr>
      <th>Алгоритм</th>
      <th>OneScript 1.9</th>
      <th>OneScript 2.0</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <td><b>GZip</b></td>
      <td colspan="2" align="center"><a href="https://learn.microsoft.com/ru-ru/dotnet/api/system.io.compression" target="_blank">System.IO.Compression</a></td>
    </tr>
    <tr>
      <td><b>Deflate</b></td>
      <td colspan="2" align="center"><a href="https://learn.microsoft.com/ru-ru/dotnet/api/system.io.compression" target="_blank">System.IO.Compression</a></td>
    </tr>
    <tr>
      <td><b>Brotli</b></td>
      <td align="center"><a href="https://github.com/master131/BrotliSharpLib" target="_blank">BrotliSharpLib</a></td>
      <td align="center"><a href="https://learn.microsoft.com/ru-ru/dotnet/api/system.io.compression" target="_blank">System.IO.Compression</a></td>
    </tr>
    <tr>
      <td><b>LZ4</b></td>
      <td colspan="2" align="center"><a href="https://github.com/MiloszKrajewski/K4os.Compression.LZ4" target="_blank">K4os.Compression.LZ4</a></td>
    </tr>
    <tr>
      <td><b>Zlib</b></td>
      <td align="center"><a href="https://github.com/haf/DotNetZip.Semverd" target="_blank">DotNetZip</a></td>
      <td align="center"><a href="https://learn.microsoft.com/ru-ru/dotnet/api/system.io.compression" target="_blank">System.IO.Compression</a></td>
    </tr>
    <tr>
      <td><b>Zstd</b></td>
      <td colspan="2" align="center"><a href="https://github.com/oleg-st/ZstdSharp" target="_blank">ZstdSharp</a></td>
    </tr>
    <tr>
      <td><b>Snappy</b></td>
      <td colspan="2" align="center"><a href="https://github.com/brantburnett/Snappier" target="_blank">Snappier</a></td>
    </tr>
  </tbody>
</table>

## Сборка

```
oscript build.os
```
