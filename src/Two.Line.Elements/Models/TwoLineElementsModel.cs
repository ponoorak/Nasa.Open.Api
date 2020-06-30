namespace Two.Line.Elements.Model
{
    using LineParsers;

    public class TwoLineElementsModel
    {
        public string Name { get; set; }
        public TleLine1Parser.Line1Model Line1 { get; set; }
        public TleLine2Parser.Line2Model Line2 { get; set; }
    }
}
