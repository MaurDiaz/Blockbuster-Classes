# CSharpActivity4.4.3

Blockbuster was a company that rented movies on VHS tapes. Create an inventory management system for Blockbuster.

1. Create a class called VHSTape. Include member variables representing the following:
  a. The name of the movie.
  b. The movie’s length (in minutes).
  c. Whether or not the movie is currently rented.
  d. How far along the tape is currently played.
2. Add functions to VHSTape to do the following:
  a. Play the tape a given amount.
  b. Rewind the tape a given amount.
  c. Set whether or not the tape is rented.
  d. A constructor that initializes the movie’s name and length to given values. The movie should initially be not rented, and rewound to the movie’s beginning.
3. Create a class called Blockbuster. Include member variables representing the following:
  a. The address of the store.
  b. A list of movies at the store.
4. Add methods to Blockbuster to do the following:
  a. Add a movie.
  b. Check if the store has a movie, given the movie’s name.
  c. Check if the store has an unrented copy of a movie, given the movie’s name.
  d. Rent a movie, given the movie’s name. This function should return the VHSTape object.
  e. Return a movie, given the movie’s name.
  f. A constructor that initializes the store’s address to a given value. The list of movies should initially be empty.
5. Complete the program.
