async function getData(username = null) {
    try {
        // Clear previous data and show loading
        document.getElementById("container").innerHTML = `
            <div class="row justify-content-center">
                <div class="col-md-8 col-lg-6">
                    <div class="card shadow border-0">
                        <div class="card-body text-center p-5">
                            <div class="spinner-border text-primary mb-3" style="width: 3rem; height: 3rem;" role="status">
                                <span class="visually-hidden">Loading...</span>
                            </div>
                            <h5>Loading GitHub data...</h5>
                            <p class="text-muted">Fetching profile information</p>
                        </div>
                    </div>
                </div>
            </div>
        `;

        if (!username) {
            username = prompt("Enter GitHub Username:");
        }
        
        if (!username || username.trim() === '') {
            showError("Please enter a valid GitHub username");
            return;
        }

        // Fetch user data
        const userResponse = await fetch(`https://api.github.com/users/${username}`);
        if (!userResponse.ok) {
            throw new Error(`User not found: ${username}`);
        }
        const data = await userResponse.json();

        // Fetch followers
        const followersResponse = await fetch(data.followers_url);
        if (!followersResponse.ok) {
            throw new Error('Failed to fetch followers');
        }
        const followers = await followersResponse.json();

        // Display the data
        displayUserData(data, followers);
    } catch (error) {
        showError(error.message);
    }
}

function displayUserData(data, followers) {
    let followersHTML = '';
    
    if (followers.length > 0) {
        followers.forEach((follower) => {
            followersHTML += `
                <div class="col-md-3 col-sm-4 col-6 mb-3">
                    <div class="card follower-card h-100 shadow-sm">
                        <img src="${follower.avatar_url}" 
                             class="card-img-top p-3 rounded-circle" 
                             alt="${follower.login}"
                             style="width: 120px; height: 120px; object-fit: cover; margin: 0 auto;">
                        <div class="card-body text-center">
                            <h6 class="card-title mb-1">${follower.login}</h6>
                            <a href="${follower.html_url}" 
                               target="_blank" 
                               class="btn btn-sm btn-outline-primary mt-2">
                                <i class="fab fa-github me-1"></i>View Profile
                            </a>
                        </div>
                    </div>
                </div>
            `;
        });
    } else {
        followersHTML = `
            <div class="col-12 text-center py-4">
                <div class="alert alert-info">
                    <i class="fas fa-users-slash me-2"></i>
                    This user has no followers yet.
                </div>
            </div>
        `;
    }

    document.getElementById("container").innerHTML = `
        <!-- User Profile Section -->
        <div class="row justify-content-center mb-5">
            <div class="col-lg-8">
                <div class="card profile-card shadow-lg border-0 overflow-hidden">
                    <div class="card-header bg-primary text-white py-4">
                        <div class="d-flex justify-content-between align-items-center">
                            <div>
                                <h3 class="mb-0"><i class="fab fa-github me-2"></i>GitHub Profile</h3>
                            </div>
                            <button class="btn btn-light" onclick="getUserPrompt()">
                                <i class="fas fa-search me-2"></i>New Search
                            </button>
                        </div>
                    </div>
                    <div class="card-body p-4">
                        <div class="row align-items-center">
                            <div class="col-md-4 text-center mb-4 mb-md-0">
                                <img src="${data.avatar_url}" 
                                     class="img-fluid rounded-circle border border-4 border-primary shadow" 
                                     alt="${data.name || data.login}"
                                     style="width: 200px; height: 200px; object-fit: cover;">
                            </div>
                            <div class="col-md-8">
                                <h2 class="mb-1">${data.name || 'No Name'}</h2>
                                <p class="text-muted mb-3">
                                    <i class="fas fa-user me-2"></i>@${data.login}
                                </p>
                                
                                ${data.bio ? `<p class="lead mb-4">${data.bio}</p>` : ''}
                                
                                <div class="row g-3 mb-4">
                                    <div class="col-md-6">
                                        <div class="card stats-card h-100">
                                            <div class="card-body text-center">
                                                <h1 class="display-5 text-primary">${data.public_repos}</h1>
                                                <p class="text-muted mb-0">Public Repositories</p>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="col-md-6">
                                        <div class="card stats-card h-100">
                                            <div class="card-body text-center">
                                                <h1 class="display-5 text-success">${data.followers}</h1>
                                                <p class="text-muted mb-0">Followers</p>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="col-md-6">
                                        <div class="card stats-card h-100">
                                            <div class="card-body text-center">
                                                <h1 class="display-5 text-info">${data.following}</h1>
                                                <p class="text-muted mb-0">Following</p>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="col-md-6">
                                        <div class="card stats-card h-100">
                                            <div class="card-body text-center">
                                                <h1 class="display-5 text-warning">${data.public_gists || 0}</h1>
                                                <p class="text-muted mb-0">Public Gists</p>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                
                                <div class="d-flex flex-wrap gap-2">
                                    ${data.location ? `
                                        <span class="badge bg-light text-dark p-2">
                                            <i class="fas fa-map-marker-alt me-1"></i>${data.location}
                                        </span>
                                    ` : ''}
                                    
                                    ${data.blog ? `
                                        <a href="${data.blog}" target="_blank" class="badge bg-info text-white p-2 text-decoration-none">
                                            <i class="fas fa-link me-1"></i>Website
                                        </a>
                                    ` : ''}
                                    
                                    ${data.twitter_username ? `
                                        <a href="https://twitter.com/${data.twitter_username}" target="_blank" class="badge bg-primary text-white p-2 text-decoration-none">
                                            <i class="fab fa-twitter me-1"></i>@${data.twitter_username}
                                        </a>
                                    ` : ''}
                                    
                                    ${data.company ? `
                                        <span class="badge bg-secondary p-2">
                                            <i class="fas fa-building me-1"></i>${data.company}
                                        </span>
                                    ` : ''}
                                </div>
                                
                                <div class="mt-4">
                                    <a href="${data.html_url}" 
                                       target="_blank" 
                                       class="btn btn-dark btn-lg">
                                        <i class="fab fa-github me-2"></i>View GitHub Profile
                                    </a>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        
        <!-- Followers Section -->
        <div class="row">
            <div class="col-12">
                <div class="card shadow border-0 mb-4">
                    <div class="card-header bg-light py-3">
                        <h4 class="mb-0">
                            <i class="fas fa-users me-2"></i>Followers (${followers.length})
                        </h4>
                    </div>
                    <div class="card-body">
                        <div class="row" id="followers-container">
                            ${followersHTML}
                        </div>
                    </div>
                </div>
            </div>
        </div>
    `;
}

function showError(message) {
    document.getElementById("container").innerHTML = `
        <div class="row justify-content-center">
            <div class="col-md-8 col-lg-6">
                <div class="card shadow border-0">
                    <div class="card-body text-center p-5">
                        <div class="text-danger mb-3">
                            <i class="fas fa-exclamation-triangle fa-4x"></i>
                        </div>
                        <h4 class="text-danger mb-3">Oops! Something went wrong</h4>
                        <p class="text-muted mb-4">${message}</p>
                        <button class="btn btn-primary" onclick="getUserPrompt()">
                            <i class="fas fa-search me-2"></i>Try Another Username
                        </button>
                    </div>
                </div>
            </div>
        </div>
    `;
}

function getUserPrompt() {
    const username = prompt("Enter GitHub Username:");
    if (username) {
        getData(username);
    }
}

// Initial call to show welcome screen
document.addEventListener('DOMContentLoaded', function() {
    // Welcome screen is already shown in HTML
});