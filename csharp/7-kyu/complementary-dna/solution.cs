public class DnaStrand 
    {
        public static string MakeComplement(string dna)
        {
            var result = "";
            for (var i = 0; i < dna.Length; i++)
            {
              if (dna[i] == 'G')
                result += 'C';
              else if (dna[i] == 'C')
                result += 'G';
              else if (dna[i] == 'T')
                result += 'A';
              else if (dna[i] == 'A')
                result += 'T';
            }
            
            return result;
        }
    }