module MathExpressionIntepreter
    open System

    type Token = 
        | Number of float
        | Add
        | Subtract
        | Multiply
        | Divide
        | LeftParentheses
        | RightParentheses
        | EndOfLine

 
    let private isDigit x = Char.IsDigit x

    let rec private Tokenize list : (Token list)=
        match list with
        | [] -> [EndOfLine]

        | head :: _ when isDigit head -> 
            let number,list = makeNumber 0.0 list
            checkNumber (Seq.toList (number|>string)) 0 0
            Number number :: Tokenize list

        | '+' :: tail -> Add :: Tokenize tail
        | '-' :: tail -> Subtract :: Tokenize tail
        | 'x' :: tail -> Multiply :: Tokenize tail
        | '/' :: tail -> Divide :: Tokenize tail
        | '(' :: tail -> LeftParentheses :: Tokenize tail
        | ')' :: tail -> RightParentheses :: Tokenize tail
        | ' ' :: tail -> Tokenize tail
        | _ -> raise(System.Exception("Lexer Error : Invalid Character " + (list.Head|>string)))

    and private makeNumber num list = 
        match list with
        | [] -> (num,[])
        | '0' :: tail -> makeNumber (num * 10.0) tail
        | '1' :: tail -> makeNumber (num * 10.0 + 1.0) tail
        | '2' :: tail -> makeNumber (num * 10.0 + 2.0) tail
        | '3' :: tail -> makeNumber (num * 10.0 + 3.0) tail
        | '4' :: tail -> makeNumber (num * 10.0 + 4.0) tail
        | '5' :: tail -> makeNumber (num * 10.0 + 5.0) tail
        | '6' :: tail -> makeNumber (num * 10.0 + 6.0) tail
        | '7' :: tail -> makeNumber (num * 10.0 + 7.0) tail
        | '8' :: tail -> makeNumber (num * 10.0 + 8.0) tail
        | '9' :: tail -> makeNumber (num * 10.0 + 9.0) tail
        | '.' :: tail -> 
            let list,decimal = makeDecimalNumber 0.0 1.0 tail
            makeNumber (num + decimal) list
        | _ -> (num,list)


    and private makeDecimalNumber num scale list = 
        match list with 
        | [] -> [],(num/scale)
        | '0' :: tail -> makeDecimalNumber (num * 10.0) (scale * 10.0) tail
        | '1' :: tail -> makeDecimalNumber (num * 10.0 + 1.0) (scale * 10.0) tail
        | '2' :: tail -> makeDecimalNumber (num * 10.0 + 2.0) (scale * 10.0) tail
        | '3' :: tail -> makeDecimalNumber (num * 10.0 + 3.0) (scale * 10.0) tail
        | '4' :: tail -> makeDecimalNumber (num * 10.0 + 4.0) (scale * 10.0) tail
        | '5' :: tail -> makeDecimalNumber (num * 10.0 + 5.0) (scale * 10.0) tail
        | '6' :: tail -> makeDecimalNumber (num * 10.0 + 6.0) (scale * 10.0) tail
        | '7' :: tail -> makeDecimalNumber (num * 10.0 + 7.0) (scale * 10.0) tail
        | '8' :: tail -> makeDecimalNumber (num * 10.0 + 8.0) (scale * 10.0) tail
        | '9' :: tail -> makeDecimalNumber (num * 10.0 + 9.0) (scale * 10.0) tail
        | _ -> list,(num/scale)

    and private checkNumber (list: char list) intDigits decimalDigits = 
        if list.IsEmpty then 
            if (decimalDigits > 0) && (intDigits > 2) then
                raise (System.Exception("Decimal Numbers Can Only Have Upto 2 Integer Digits"))
            elif intDigits > 3 then
                raise (System.Exception("Integer Numbers Can Only Have Upto 3 Integer Digits"))
        else
            match list with
            | head :: tail when isDigit head -> 
                checkNumber tail (intDigits + 1) decimalDigits
            | '.' :: tail -> checkNumber [] intDigits (countDecimalDigits tail 0)

    and private countDecimalDigits list decimalDigits = 
        if decimalDigits > 2 then
            raise (System.Exception("Decimal Numbers Can Only Have Upto 2 Decimal Digits"))
        elif list.IsEmpty then
            decimalDigits
        else 
            countDecimalDigits list.Tail (decimalDigits + 1)

    // Sestoft P., Friis Larsen K. and Hallenberg N. (1994) 'Grammars and parsing with F#' Page 29
    // Grammar in BNF:
    // E = T Eopt
    // Eopt = "+" T Eopt | "-" T Eopt | empty
    // T = F Topt
    // Topt = "x" F Topt | "/" F Topt | empty
    // F = "-" "Number" value |"Number" value | "(" E ")"


    // Sestoft P., Friis Larsen K. and Hallenberg N. (1994) 'Grammars and parsing with F#' Page 31
    let private parseAndEvaluate tokenList = 
        let rec E tokenList = (T >> Eopt) tokenList
        and Eopt (tokenList, value) = 
            match tokenList with
            | Add :: tail -> 
                let (tokenList, tokenValue) = T tail
                Eopt (tokenList, value + tokenValue)

            | Subtract :: tail ->
                let (tokenList, tokenValue) = T tail
                Eopt (tokenList, value - tokenValue)

            | _ -> (tokenList, value)

        and T tokenList = (F >> Topt) tokenList

        and Topt (tokenList, value) = 
            match tokenList with
            | Multiply :: tail ->
                let (tokenList, tokenValue) = F tail
                Topt (tokenList, value * tokenValue)

            | Divide :: tail ->
                let (tokenList, tokenValue) = F tail
                Topt (tokenList, value / tokenValue)

            | _ -> (tokenList, value)

        and F tokenList =
            match tokenList with
            | Number value :: tail -> (tail, value)
            | Subtract :: Number value :: tail -> (tail, 0.0-value)

            | LeftParentheses :: tail -> 
                let (tokenList, tokenValue) = E tail
                match tokenList with 
                | RightParentheses :: tail -> (tail, tokenValue)
                | _ -> raise (System.Exception("Left Parentheses Given Without Right Parentheses"))

            | _ -> raise (System.Exception("Parser Error : Input Does Not Match Grammer"))

        E tokenList


    let Evaluate (input:string) = 
        snd (input|>Seq.toList|>Tokenize|>parseAndEvaluate)
        