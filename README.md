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
