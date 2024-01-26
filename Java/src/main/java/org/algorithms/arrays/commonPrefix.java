package org.algorithms.arrays;

public class commonPrefix {

    public static String longestCommonPrefix(String[] strs) {
        String prefix = "" ;
        String prefixJ = "" ;
        String commonPrefix ="" ;
        for (var i =0 ; i<strs.length;i++) {
            prefix = strs[0].substring(0,i+1);

            for(var j =0; j<strs.length;j++) {
                if(i != j) {
                    prefixJ = strs[j].substring(0, i + 1);
                    if (!prefix.equals(prefixJ)) {
                        break;
                    } else {
                        commonPrefix = prefix.substring(0, i);
                    }
                }
            }
        }
        return commonPrefix ;
    }


}
