# Futoshiki
Through this project I sought to develop a desktop application and gain experience of the software development life cycle. This is a Windows Presentation Foundation application. Being a keen problem solver, I seized the opportunity to create my own version of a logic puzzle that I find enjoyable: futoshiki.

![WelcomePage](https://user-images.githubusercontent.com/54633579/71023097-f0602600-20f9-11ea-97b0-ae21fd2e9b7e.png)
*Figure 1: The opening page welcomes the user and summarises futoshiki.*

### Idea Generation
Futoshiki is centred around the concept of a latin square: an n by n grid in which each of n symbols occurs once in each row and column. The following example uses letters A to D:  
<p align="center">A . D . C . B<br>  
C . A . B . D<br>  
B . C . D . A<br>  
D . B . A . C</p>     
            
[Futoshiki](https://www.futoshiki.org), aka Unequal, is the inspiration for this idea.
It uses inequality symbols to give the player enough info to deduce the solution.
For instance, in a 3-by-3 latin square if _ > _ then the left-hand side cannot be 1 and the right-hand side cannot be 3. Now suppose you had already proved a 2 or a 3 in the same column as the left-hand space, or a 1 or a 2 in the same column as the right-hand space, you could, then, logically conclude this space's value.   

A 3X3 grid may be too easy, so 4X4 is probably best.
      
Potential Issues: Generating arrays automatically, so may have to design arrays manually.
                  
### Log 1
Much work was done on the user interface. I hardcoded the answer to the puzzle and added a submit button. The next step is to allow the user to increment up and down between 1 and 4 using the directional arrows. This is easily accomplished by changing from textboxes to combo-boxes.
      
### Log 2
I firstly changed the textboxes to comboboxes which allowed the design of an improved user interface. I then added additional windows. 10 windows seems a good amount. The next steps are to add 4 more quizzes and add inequality symbols.
      
### Log 3
The application now has 11 windows: a start window, which describes futoshiki, and 10 consecutive puzzles. A clickable button progresses the user from start page to the first puzzle by creating, and showing (.Show()), an object of the required WPF window; simultaneously, the command this.Close() causes the opening window to close. The cs file for each of the last 10 windows is similar: an intitialisation of the puzzle solution, a declaration of each combobox followed by intialisation by parsing user input, and an if statement that verifies that the user-input matches the correct answer in every combobox. The latter was efficiently achieved by concatenating the if statement of each combobox using the & operator.

      
Should the user not input the correct integer in every combox, the message-box "Wrong answer. Keep Trying" appears. The latter sentence has the aim of stopping the user becoming discouraged. The correct solution generates a message of congratulation such as "Success! Let's try another". Closing this message box opens the next exercise.
![WrongAnswer](https://user-images.githubusercontent.com/54633579/71023368-7f6d3e00-20fa-11ea-9123-549597975148.png)

*Figure 2: Should the user submit a completed, incorrect solution, he/she is encouraged to keep trying.*

### To improve
The major issue is that clicking the submit button whilst any of the comboxes are void causes the program to crash. This occurs because user_input is in an incorrect format as there wasn't any text to parse and convert to an integer. One possible solution is to add a 0-option to the comboxes which can't be seen. This would result in the user_input holding the value 0, rather than null. Another solution could involve an enveloping if statement that is satisfied if every combox is filled. More general improvements to the application include more aesthetically pleasing windows. Additionally, usability may be ameliorated by allowing the user to toggle left and right between comboxes with the left and right keyboard directional buttons. Currently, the user may type into a combobox by double clicking on it or by pushing the tab key. Once in a combobox the user may cycle through numbers using the horizontal or vertical directional arrows or by pushing a number key (only 1 - 4 are permitted).

### Exception Handling
The high-risk defect decribed above, of empty comboboxes leading to failure, was resolved through a method not previously suggested. A try-catch statement has been implemented which prevents System.FormatException from crashing the program. Instead, a message-box informs the user "You have not filled in all the boxes." This message may be dismissed, by pressing the enter key or by clicking OK, which allows the program to continue as before.
![ExceptionHandled](https://user-images.githubusercontent.com/54633579/71023664-205bf900-20fb-11ea-89a9-8f73686c34bb.png)

*Figure 3: Should the user submit an incomplete solution, a try-catch statement handles an exception whilst generating a message-box.*

## Solution
![Page1](https://user-images.githubusercontent.com/54633579/71072283-10352f80-2176-11ea-818e-6018be833668.png)
![Page2](https://user-images.githubusercontent.com/54633579/71072310-217e3c00-2176-11ea-951e-7fd2576837fb.png)
![Page3](https://user-images.githubusercontent.com/54633579/71072327-2b07a400-2176-11ea-8bd3-367ad6235ef2.png)
![Page4](https://user-images.githubusercontent.com/54633579/71072649-da447b00-2176-11ea-95bd-1f1c47ed9ff1.png)
![Page5](https://user-images.githubusercontent.com/54633579/71072705-f21bff00-2176-11ea-96d3-79636a48acfb.png)
![Page6](https://user-images.githubusercontent.com/54633579/71072729-ff38ee00-2176-11ea-8624-f510e12409a8.png)
![Page7](https://user-images.githubusercontent.com/54633579/71072767-1081fa80-2177-11ea-8aa5-17be99bfccad.png)
![Page8](https://user-images.githubusercontent.com/54633579/71072793-1a0b6280-2177-11ea-9fe6-abe876ca2816.png)
![Page9](https://user-images.githubusercontent.com/54633579/71072805-21327080-2177-11ea-963d-9ab41415b5ab.png)
![Page10cropped](https://user-images.githubusercontent.com/54633579/71082295-c0139880-2188-11ea-8fdb-aaed229345dc.png)

*Figure 4: Correct answers to all puzzles.*
