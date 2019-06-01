package com.testandroid.test;

import org.junit.Test;
import java.util.ArrayList;
import java.util.Collection;
import java.util.Collections;
import java.util.HashMap;
import java.util.List;
import java.util.TreeMap;

import static org.junit.Assert.*;

/**
 * El Algoritmo consiste en lo siguiente: la funcion getMin recibira por parametro un array
 * con valores repetidos aleatoriamente.
 *
 * Entonces se debe retornar el valor del array, cuya suma de posiciones donde se repite(que obviamente tiene que ser mayor que uno)
 * sea el menor valor absoluto.
 *
 * Ejemplo [2,1,3,2,1] -> esto deberia retornar 2, porque se repite en la posicion 0 y 3 cuya suma de
 * valores es 3, a diferencia del 1 que se repite en la posicion 1 y 4 y suma de posiciones da 5.
 *
 */
public class MinimunPositionUnitTest {

    public int getMin(int[] arr) {

        List<Integer> already = new ArrayList<>();
        TreeMap<Integer, Integer> map = new TreeMap<>();

        int cont = 0;
        int acum = 0;


        for(int i = 0; i < arr.length; i++){
            for(int j = 0; j < arr.length; j++){

                    if(arr[i] == arr[j]){
                        cont++;
                        acum += j;
                    }
            }

            if(!already.contains(arr[i])){

                if(cont > 1){
                    map.put(acum, arr[i]);
                }

                already.add(arr[i]);
            }

            cont = 0;
            acum = 0;

        }

        return searchMin(map);

    }

    private int searchMin(TreeMap<Integer, Integer> map){

        int min = -1;

        if(map.isEmpty()){
            return min;
        }
        min = map.firstEntry().getValue();
        return min;

    }



    @Test
    public void addition_isCorrect() {


        assertEquals(-1, getMin(new int[]{1, 2, 3, 4})); //return -1
        assertEquals(2, getMin(new int[]{1, 2, 3, 2, 4})); //2(1,3) = 4
        assertEquals(3, getMin(new int[]{1, 2, 3, 3, 4, 2, 4, 2})); // 2(1,4,6)=13 3(2,3)=5
        assertEquals(1, getMin(new int[]{1, 1, 0, 1, 1, 2, 3, 3, 4, 2, 4, 2})); // 1(0,1,3,4)=8 2(5,9,11)=25  4(8, 10) = 18
    }
}