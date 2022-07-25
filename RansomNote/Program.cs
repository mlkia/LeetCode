// See https://aka.ms/new-console-template for more information

//383. Ransom Note

//https://leetcode.com/problems/ransom-note/


 bool CanConstruct(string ransomNote, string magazine){

	var dict = new Dictionary<char, int>();
	foreach (var c in magazine) {
		if (dict.ContainsKey(c)) {
			dict[c]++;  
		} else {
			dict[c] = 1;  // The value for key (c) is 1
		}
	}

	foreach (var c in ransomNote){
		if (dict.ContainsKey(c)){
			dict[c]--;

			if (dict[c] < 0){
				return false;
			}
		}else {
			return false;
		}
	} 
	return true;
}


Console.WriteLine(CanConstruct("aab", "aabmn")); //True
Console.WriteLine(CanConstruct("aab", "abb"));  //False



