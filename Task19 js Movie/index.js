
let list = document.querySelector("#list")
axios("https://api.tvmaze.com/show")
.then(res=>{
    console.log(res.data);
    for(let i = 0 ; i<res.data.length; i++){
        list.innerHTML +=`<div class="col-12 col-sm-12 col-md-6 col-lg-6 col-xl-4 col-xxl-3 mt-4"><div class="card" style="width: 18rem;">
    <img src="${res.data[i].image.medium}" class="card-img-top" alt="...">
    <div class="card-body rounded-bottom">
      <h5 class="card-title text-white">${res.data[i].name}</h5>
      <p class="card-text text-white">imdb : ${res.data[i].rating.average}</p>
      <p class="card-text text-white">premiered : ${res.data[i].premiered}</p>
      <p class="card-text text-white">language : ${res.data[i].language}</p>
      <a href="${res.data[i].url}" class="btn btn-dark">Go to page</a>
    </div>
  </div>
  </div>`
    }
})

document.getElementById("searchForm").addEventListener("submit", function(event) {
    event.preventDefault();
    
    let searchTerm = document.getElementById("searchInput").value; 
    
    axios.get(`https://api.tvmaze.com/search/shows?q=${searchTerm}`)
        .then(response => {
            list.innerHTML = ""; 
            response.data.forEach(show => {
                list.innerHTML += `<div class="col-12 col-sm-12 col-md-6 col-lg-6 col-xl-4 col-xxl-3 mt-4">
                                        <div class="card" style="width: 18rem;">
                                            <img src="${show.show.image.medium}" class="card-img-top" alt="...">
                                            <div class="card-body rounded-bottom">
                                                <h5 class="card-title text-white">${show.show.name}</h5>
                                                <p class="card-text text-white">IMDB : ${show.show.rating.average}</p>
                                                <p class="card-text text-white">Premiered : ${show.show.premiered}</p>
                                                <a href="${show.show.url}" class="btn btn-dark">Go to page</a>
                                            </div>
                                        </div>
                                    </div>`;
            });
        })
});


function createYearLis() {
    const select = document.getElementById("yearSelect");
    for (let year = 1950; year <= 2024; year++) {
        const option = document.createElement("option");
        option.text = year;
        option.value = year;
        select.add(option);
    }
}

document.addEventListener("DOMContentLoaded",createYearLis );

document.getElementById("yearSelect").addEventListener("change", function() {
    const selectedYear = this.value;
    if (selectedYear === "İl seçin") {
        
        fetchShows("https://api.tvmaze.com/shows");
    } else {
        
        fetchAllShowsAndFilter(selectedYear);
    }
});

function fetchAllShowsAndFilter(selectedYear) {
    axios.get("https://api.tvmaze.com/shows")
        .then(response => {
            const allShows = response.data;
            const filteredShows = allShows.filter(show => {
                const premieredYear = new Date(show.premiered).getFullYear();
                return premieredYear == selectedYear;
            });
            renderShows(filteredShows);
        })
       
}

function fetchShows(url) {
    axios.get(url)
        .then(response => {
            renderShows(response.data);
        })
       
}

function renderShows(shows) {
    list.innerHTML = ""; 
    shows.forEach(show => {
        list.innerHTML += `<div class="col-12 col-sm-12 col-md-6 col-lg-6 col-xl-4 col-xxl-3 mt-4">
                                <div class="card" style="width: 18rem;">
                                    <img src="${show.image.medium}" class="card-img-top" alt="...">
                                    <div class="card-body rounded-bottom">
                                        <h5 class="card-title text-white">${show.name}</h5>
                                        <p class="card-text text-white">IMDB : ${show.rating.average}</p>
                                        <p class="card-text text-white">Premiered : ${show.premiered}</p>
                                        <a href="${show.url}" class="btn btn-dark">Go to page</a>
                                    </div>
                                </div>
                            </div>`;
    });
}



