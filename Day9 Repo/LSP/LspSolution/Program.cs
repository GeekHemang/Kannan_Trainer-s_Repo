using LspSolution.Domain;

var squrare = new Square(10);
squrare.SetSide(20);

Console.WriteLine("width is " + squrare.GetSide());
Console.WriteLine("height is " + squrare.GetSide());

var smallRectangle = new Rectangle(30, 40);
smallRectangle.SetWidth(50);

Console.WriteLine("width is " + smallRectangle.GetWidth());
Console.WriteLine("height is " + smallRectangle.GetHeight());





void ShoudNotChangeWidth_IfHeightIsModified(Rectangle rect)
{

    //assert this statement
    int beforeChangeWidth = rect.GetWidth();
    rect.SetHeight(rect.GetHeight() + 50);
    Console.WriteLine("changed height is " + rect.GetHeight());
    int afterChangeWidth = rect.GetWidth();

    Console.WriteLine(beforeChangeWidth == afterChangeWidth);
    Console.WriteLine(beforeChangeWidth);
    Console.WriteLine(afterChangeWidth);


}

ShoudNotChangeWidth_IfHeightIsModified(smallRectangle);

ShoudNotChangeWidth_IfHeightIsModified(new Square(10));//syntax error