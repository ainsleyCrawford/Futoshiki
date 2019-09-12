# GameProject_Week5
Idea_1: A Latin-Square type game:
      A latin square has n rows and n columns, and each symbol may occur only once in each.
      Latin Square example:
            A     D     C     B
            C     A     B     D
            B     C     D     A
            D     B     A     C     
      Futoshiki (https://www.futoshiki.org/), aka Unequal, is the inspiration for this idea.
      It uses inequality symbols to give the player enough info to deduce the solution.
            a > b , c < d
            ^   ,   ,   ,
            e , f , g , h
            ,   ,   ^   ,
            i , j , k < l
            ,   ,   ,   ,
            m , n , o , p
      
      A 3X3 grid may be too easy, so 4X4 is probably best.
      
      Potential Issues: Generating arrays automatically, so may have to design arrays manually.
      
      
Idea_2: Quiz
       Perhaps a capital to country pair game.
       User presented w/ capital --> selects country from list.
       Pair quiz example:
            Paramaribo is the capital of [Guyana]/[Azerbaijan]/[Suriname]/[Panama]
            
Day_1:
      Much work was done on the user interface. I hardcoded the answer to the puzzle and added a submit button.
      The next step is to allow the user to increment up and down between 1 and 4 using the directional arrows.
      This is easily accomplished by changing from textboxes to combo-boxes.
Day_2:
      I firstly changed the textboxes to comboboxes which allowed the design of an improved user interface.
      I then added additional windows. 10 windows seems a good amount.
      The next steps are to add 4 more quizes and add inequality symbols.
Day_3:
      The application now has 11 windows: a start window, which describes futoshiki, and 10 consecutive puzzles.
      A clickable button progresses the user from start page to the first puzzle by creating, and showing (.Show()), an object of the
      required WPF window; simultaneously, the command this.Close() causes the opening window to close.
      The cs file for each of the last 10 windows is similar: an intitialisation of the puzzle solution, a declaration of each combobox
      followed by intialisation by parsing user input, and an if statement that verifies that the user input matches the correct answer
      in every combobox. The latter was efficiently achieved by concatenating the if statement of each combobox using the & operator.
