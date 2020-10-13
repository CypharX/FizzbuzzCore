# FizzbuzzCore
 Fizzbuzz in MVC

This site accepts 2 numbers then prints out all numbers between 1 and 100 replacing all multiples of the first number with fizz, all multiples of the second number with buzz and all multiples of both numbers with FIZZBUZZ!!. It uses the modulus operator in the following loop to determine multiples and the "AppendLine" method to add them to the string.
```
for(var index = 1; index <= 100; index++)
            {   
                if(index % fizzNum == 0 && index % buzzNum == 0)
                {
                    output.AppendLine("Fizzbuzz!!");
                }
                else if(index % fizzNum == 0)
                {
                    output.AppendLine("Fizz");
                }
                else if(index % buzzNum == 0)
                {
                    output.AppendLine("buzz");
                }
                else
                {
                    output.AppendLine(index.ToString());
                }
            }
 ```
