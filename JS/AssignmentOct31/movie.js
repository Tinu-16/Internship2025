var movies=[
  {
    "MovieName": "The Great Adventure",
    "ActorName": "John Smith",
    "ReleaseDate": "2023-01-15"
  },
  {
    "MovieName": "Mystery in the Woods",
    "ActorName": "Emily Johnson",
    "ReleaseDate": "2022-09-28"
  },
  {
    "MovieName": "Love and Destiny",
    "ActorName": "Michael Brown",
    "ReleaseDate": "2023-05-02"
  },
  {
    "MovieName": "City of Shadows",
    "ActorName": "Sophia Williams",
    "ReleaseDate": "2023-03-12"
  },
  {
    "MovieName": "The Last Stand",
    "ActorName": "William Davis",
    "ReleaseDate": "2022-11-07"
  },
  {
    "MovieName": "Echoes of Time",
    "ActorName": "Olivia Wilson",
    "ReleaseDate": "2022-12-19"
  }
]
//1. List the movie name along with the actor name of those movies released in the year 2022
console.log(movies.filter(h => h.ReleaseDate.split('-')[0] === "2022").map(h => ({MovieName:h.MovieName,ActorName:h.ActorName})))

//2. List the movie names released in the year 2023 where the actor is William Davis.
console.log(movies.filter(h => h.ReleaseDate.split('-')[0] === "2022" && h.ActorName=="William Davis"))

//3. Retrieve the Actor name and release date of the movie “The Last Stand”
console.log(movies.filter(h => h.MovieName==="The Last Stand").map(h => ({ActorName:h.ActorName,ReleaseDate:h.ReleaseDate})))

//4. Check whether there is any movie in the list with actor name “John Doe”
console.log(movies.some(h => h.ActorName === "John Doe" ));

//5. Display the count of movies where the actor name is "Sophia Williams"
console.log(movies.filter(h => h.ActorName==="Sophia Williams").length)

//6. Insert an element as last element
movies.push({
   			 "MovieName": "The Final Stage",
    			"ActorName": "John Doe",
   	 		"ReleaseDate": "2022-08-11"
 		 }
)
console.log(movies)

//7. Check whether there exists any duplicate movie names present in the array
function duplicateMovie(movies) {
  const uniqueMovies = new Set();
  for (const movie of movies) {
    if (uniqueMovies.has(movie)) {
      return true; 
    }
    uniqueMovies.add(movie);
  }
  return false; 
}
console.log(duplicateMovie(movies));

//8. Create a new array starting from the movie "City of Shadows"
const index =movies.findIndex(m => m.MovieName === "City of Shadows");
var newArrayList=movies.slice(index)
console.log(newArrayList)

//9. List the distinct actor names in array
const distinctActorsList = new Set(movies.map(m => m.ActorName));
console.log(distinctActorsList)

//10. Insert an element as next element to movie “Love and Destiny”
const newMovie = {
  MovieName: "Rich & Poor",
  ActorName: "Johnie Walker",
  ReleaseDate: "2023-08-11"
};
const newArray = movies.findIndex(m => m.MovieName === "Love and Destiny");
if (newArray !== -1) {
  movies.splice(index , 0, newMovie); 
}
console.log(movies);

//11. Display the count of distinct actor names in array
const distinctActors = new Set(movies.map(m => m.ActorName));
const count = distinctActors.size;
console.log(count);

//12. Remove the movie named  "The Last Stand"
const newList = movies.filter(m => m.MovieName !== "The Last Stand");
console.log(newList);

//13. Check whether all the movies are released after 2021 Dec 31
const checkMovie = movies.every(m => new Date(m.ReleaseDate) > new Date("2021-12-31"));
console.log(checkMovie);

//14. Update movie named  "City of Shadows" ‘s release date as  "2023-03-13"
const movieIndex = movies.findIndex(m => m.MovieName === "City of Shadows");
if (movieIndex !== -1) {
  movies[movieIndex].ReleaseDate = "2023-03-13";
}
console.log(movies)

//15. Create a new array of movie names whose movie name length is greater than 10.
const movieNames = movies.filter(m => m.MovieName.length > 10).map(m => m.MovieName);
console.log(movieNames);