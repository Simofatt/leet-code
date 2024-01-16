package org.algorithms.arrays;

public class commonPrefix {

    public static String LongestCommonPrefix(String[] strs) {
        String prefix = "" ;
        String prefixJ = "" ;
        String commonPrefix ="" ;
        for (var i =1 ; i<=strs.length;i++) {
            prefix = strs[0].substring(0,i);

            for(var j =i; j<strs.length;j++) {
               prefixJ = strs[j].substring(0,i);
                if(!prefix.equals(prefixJ)) {
                    break ;
                }else {
                    commonPrefix = prefix.substring(0, i - 1);
                }
            }
        }
        return commonPrefix ;
    }


}
