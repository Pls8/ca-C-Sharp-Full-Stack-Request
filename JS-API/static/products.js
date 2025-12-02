// const BaseURL = "https://fakeapi.net/";

// //let productsList, productDetails, cartList;

// fetch(BaseURL + "products")
//   .then((res) => res.json())
//   .then((data) => console.log(data))
//   .catch((err) => console.log(err));

// let main = document.querySelector("#app");
// let productsList = document.createElement("ul");
// productsList.classList.add("products-list");
// main.appendChild(productsList);

// fetch(BaseURL + "products")
//   .then((res) => res.json())
//   .then((data) => {
//     data.forEach((product) => {
//       let productItem = document.createElement("li");
//       productItem.innerText = product.name;
//       productsList.appendChild(productItem);
//     });
//   })
//   .catch((err) => console.log("Error fetching products:", err));



// let user = { name: "John Doe", email: "john@example.com" };
// async function createUser(user) {
//     let response = await fetch(BaseURL + "users", {
//       method: "POST",
//       headers: {
//         "Content-Type": "application/json",
//       },
//       body: JSON.stringify(user),
//     }).then((res) => res.json())
//     .then((data) => console.log(data))
//     .error((err) => console.log(err));
   
// //     if (!response.ok) {
// //       throw new Error("Failed to create user");
// //     }
// //     console.log("User created successfully");
// //   } catch (error) {
// //     console.error("Error creating user:", error);
// //   }
// };

// let userStat = createUser(user);


async function getData() {
    try {
        // Show loading state
        document.getElementById("products").innerHTML = `
            <div class="col-12 text-center py-5">
                <div class="spinner-border text-primary" role="status">
                    <span class="visually-hidden">Loading...</span>
                </div>
                <p class="mt-2">Loading products...</p>
            </div>
        `;
        
        let response = await fetch("https://fakestoreapi.com/products");
        if (!response.ok) throw new Error('Failed to fetch products');
        
        let data = await response.json();
        localStorage.setItem("products", JSON.stringify(data));
        display();
    } catch (error) {
        document.getElementById("products").innerHTML = `
            <div class="col-12 text-center py-5">
                <div class="alert alert-danger" role="alert">
                    <i class="fas fa-exclamation-triangle me-2"></i>
                    Error loading products: ${error.message}
                </div>
                <button class="btn btn-primary mt-3" onclick="getData()">
                    <i class="fas fa-redo me-2"></i>Try Again
                </button>
            </div>
        `;
    }
}

async function display() {
    try {
        let products = JSON.parse(localStorage.getItem("products")) || [];
        let productsData = "";
        
        if (products.length === 0) {
            productsData = `
                <div class="col-12 text-center py-5">
                    <div class="alert alert-warning" role="alert">
                        <i class="fas fa-info-circle me-2"></i>
                        No products found
                    </div>
                </div>
            `;
        } else {
            products.forEach((product) => {
                // Format price
                const price = `$${product.price.toFixed(2)}`;
                
                // Limit title length
                const shortTitle = product.title.length > 50 
                    ? product.title.substring(0, 50) + '...' 
                    : product.title;
                
                // Generate star rating
                const ratingStars = generateStars(product.rating.rate);
                
                productsData += `
                    <div class="col-md-4 col-lg-3">
                        <div class="card h-100 product-card shadow-sm" onclick='saveId(${product.id})' 
                             style="cursor: pointer; transition: transform 0.3s;">
                            <div class="card-img-wrapper" style="height: 200px; overflow: hidden;">
                                <img src="${product.image}" class="card-img-top p-3" 
                                     alt="${product.title}" style="height: 100%; object-fit: contain;">
                            </div>
                            <div class="card-body d-flex flex-column">
                                <h5 class="card-title" style="font-size: 0.95rem;">${shortTitle}</h5>
                                
                                <div class="mt-auto">
                                    <div class="d-flex justify-content-between align-items-center mb-2">
                                        <span class="badge bg-info">${product.category}</span>
                                        <span class="text-success fw-bold">${price}</span>
                                    </div>
                                    
                                    <div class="d-flex justify-content-between align-items-center">
                                        <div class="rating">
                                            ${ratingStars}
                                            <small class="text-muted">(${product.rating.count})</small>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="card-footer bg-transparent border-top-0">
                                <button class="btn btn-primary w-100">
                                    <i class="fas fa-eye me-2"></i>View Details
                                </button>
                            </div>
                        </div>
                    </div>
                `;
            });
        }
        
        document.getElementById("products").innerHTML = productsData;
        
        // Add hover effect
        document.querySelectorAll('.product-card').forEach(card => {
            card.addEventListener('mouseenter', () => {
                card.style.transform = 'translateY(-5px)';
            });
            card.addEventListener('mouseleave', () => {
                card.style.transform = 'translateY(0)';
            });
        });
    } catch (error) {
        console.error('Error displaying products:', error);
    }
}

function generateStars(rating) {
    let stars = '';
    const fullStars = Math.floor(rating);
    const hasHalfStar = rating % 1 >= 0.5;
    
    // Full stars
    for (let i = 0; i < fullStars; i++) {
        stars += '<i class="fas fa-star text-warning"></i>';
    }
    
    // Half star
    if (hasHalfStar) {
        stars += '<i class="fas fa-star-half-alt text-warning"></i>';
    }
    
    // Empty stars
    const emptyStars = 5 - fullStars - (hasHalfStar ? 1 : 0);
    for (let i = 0; i < emptyStars; i++) {
        stars += '<i class="far fa-star text-warning"></i>';
    }
    
    return stars;
}

function saveId(id) {
    localStorage.setItem("id", id);
    // Navigate to details page
    window.location.href = "./details.html";
}

// Initialize on page load
document.addEventListener('DOMContentLoaded', function() {
    // Check if products are already in localStorage
    const products = JSON.parse(localStorage.getItem("products"));
    if (products && products.length > 0) {
        display();
    } else {
        getData();
    }
});

