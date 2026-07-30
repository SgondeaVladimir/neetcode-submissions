public class Solution {
    public int[] ReplaceElements(int[] arr) {
        for(int i=0;i<arr.Length-1;i++){
            int maxi=-1;
            for(int j=i+1;j<arr.Length;j++){
                if(arr[j]>maxi)maxi=arr[j];
            }
            arr[i]=maxi;
        }
        arr[arr.Length-1]=-1;
        return arr;    
    }
}