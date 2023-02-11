namespace Exercism.WhileLoops
{
    public static class ProteinTranslation
    {
        public static string[] Proteins(string strand)
        {
            List<string> codons = new List<string>();
            for (int i = 0; i <= strand.Length - 3; i += 3)
                codons.Add(strand.Substring(i, 3));

            List<string> output = new();
            foreach (string codon in codons)
            {
                if (codon == "UAA" || codon == "UAG" || codon == "UGA")
                    break;
                switch (codon)
                {
                    case "AUG": output.Add("Methionine"); break;
                    case "UUU": case "UUC": output.Add("Phenylalanine"); break;
                    case "UUA": case "UUG": output.Add("Leucine"); break;
                    case "UCU": case "UCC": case "UCA": case "UCG": output.Add("Serine"); break;
                    case "UAU": case "UAC": output.Add("Tyrosine"); break;
                    case "UGU": case "UGC": output.Add("Cysteine"); break;
                    case "UGG": output.Add("Tryptophan"); break;
                    default: break;
                }
            }
            return output.ToArray();
        }
    }
}
