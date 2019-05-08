# Lotto_Project

##What the application does

This program generates lotto or power ball numbers, the draws are displayed on screen. In addition to this the results are saved to a file LottoResults.txt, and the statistics saved in Lotto_Statistics.csv. For every subsequent draw these files are updated with the results.

##How it was developed. 

The IO module (OutPutWriter)is billed using the singleton pattern to reduce the IO operations which are billed in to the constructor and destructor, this pattern should also reduce any conflicts when writing to file.

