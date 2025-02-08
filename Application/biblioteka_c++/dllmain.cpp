#include "pch.h"

/*
 * Bright boost for pictures
 * Author: Oskar Hamerla
 * Semester 5
 * 2024 / 2025
 * 
 * 
 * DLL implemented in C++ that brights up the pixels
 * This method takes every byte that represents R, G, B and adds values to them
*/

#define exported_method extern "C" __declspec(dllexport)
exported_method
void BrightenImageCpp(char* imageData, int byteIndex, int bytesToProcess, int rowStride)
{
    int numberOfRows = bytesToProcess / rowStride;
    int rest = rowStride % 3;
    for (int i = 0; i < numberOfRows; i++)
    {
        for (int j = 0; j < rowStride - rest; j += 3, byteIndex += 3)
        {
            imageData[byteIndex] = min(255, imageData[byteIndex] + 127);
            imageData[byteIndex + 1] = min(255, imageData[byteIndex + 1] + 127);
            imageData[byteIndex + 2] = min(255, imageData[byteIndex + 2] + 127);
        }
        byteIndex += rest;
    }
}