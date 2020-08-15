# Lotto_Project

## What the application does

This program generates lotto or power ball numbers, the draws are displayed on screen. In addition the application keeps records of all draws and keeps track of basic statistics for each lotto type. The statistics and draws can be writen to a users sellected file.

The user also change the number of draws per click, and the user can sellect the range in which the balls can be drawn.

## How it was developed. 

The IO module (OutPutWriter)is billed using the singleton pattern to reduce the IO operations which are billed in to the constructor and destructor, this pattern should also reduce any conflicts when writing to file.

The lotto_statistics class is also developeed using the singleton patten to make sure that all records are managed in a single location using Dictionaries and Lists as needed.
