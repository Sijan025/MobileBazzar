<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="styles.css">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.0.0-beta3/css/all.min.css">
</head>
<body>
    <header>
        <div class="container">
            <div class="logo">
                <h1>Mobile<span>Bazaar</span></h1>
                <p>Buy & Sell Used Phones</p>
            </div>
            <nav>
                <ul>
                    <li><a href="#home">Home</a></li>
                    <li><a href="#buy">Buy Phones</a></li>
                    <li><a href="#sell">Sell Phone</a></li>
                    <li><a href="#about">About</a></li>
                    <li><a href="#contact">Contact</a></li>
                </ul>
            </nav>
            <div class="auth-buttons">
                <button id="login-btn">Login</button>
                <button id="register-btn">Register</button>
            </div>
        </div>
    </header>

    <main>
        <section id="home" class="hero">
            <div class="container">
                <div class="hero-content">
                    <h2>Buy & Sell Used Mobiles at Best Prices</h2>
                    <p>Get the best deals on used smartphones or sell your old phone quickly and safely.</p>
                    <div class="cta-buttons">
                        <a href="#buy" class="btn primary">Browse Phones</a>
                        <a href="#sell" class="btn secondary">Sell Your Phone</a>
                    </div>
                </div>
                <div class="hero-image">
                    <img src="https://via.placeholder.com/500x300" alt="Smartphones">
                </div>
            </div>
        </section>

        <section id="buy" class="buy-section">
            <div class="container">
                <h2>Browse Used Phones</h2>
                <div class="filters">
                    <select id="brand-filter">
                        <option value="">All Brands</option>
                        <option value="Apple">Apple</option>
                        <option value="Samsung">Samsung</option>
                        <option value="OnePlus">OnePlus</option>
                        <option value="Xiaomi">Xiaomi</option>
                        <option value="Google">Google</option>
                    </select>
                    <select id="price-filter">
                        <option value="">Any Price</option>
                        <option value="0-100">Under $100</option>
                        <option value="100-200">$100 - $200</option>
                        <option value="200-300">$200 - $300</option>
                        <option value="300-500">$300 - $500</option>
                        <option value="500-1000">$500 - $1000</option>
                    </select>
                    <select id="condition-filter">
                        <option value="">Any Condition</option>
                        <option value="New">New</option>
                        <option value="Like New">Like New</option>
                        <option value="Good">Good</option>
                        <option value="Fair">Fair</option>
                    </select>
                    <button id="apply-filters" class="btn primary">Apply Filters</button>
                </div>
                <div class="phone-listings" id="phone-listings">
                    <!-- Phone listings will be dynamically added here -->
                </div>
            </div>
        </section>

        <section id="sell" class="sell-section">
            <div class="container">
                <h2>Sell Your Phone</h2>
                <div class="sell-form-container">
                    <form id="sell-form">
                        <div class="form-group">
                            <label for="phone-brand">Brand</label>
                            <select id="phone-brand" required>
                                <option value="">Select Brand</option>
                                <option value="Apple">Apple</option>
                                <option value="Samsung">Samsung</option>
                                <option value="OnePlus">OnePlus</option>
                                <option value="Xiaomi">Xiaomi</option>
                                <option value="Google">Google</option>
                                <option value="Other">Other</option>
                            </select>
                        </div>
                        <div class="form-group">
                            <label for="phone-model">Model</label>
                            <input type="text" id="phone-model" required placeholder="e.g. iPhone 12, Galaxy S20">
                        </div>
                        <div class="form-group">
                            <label for="phone-condition">Condition</label>
                            <select id="phone-condition" required>
                                <option value="">Select Condition</option>
                                <option value="New">New - Sealed in box</option>
                                <option value="Like New">Like New - No signs of use</option>
                                <option value="Good">Good - Minor signs of use</option>
                                <option value="Fair">Fair - Visible wear but works well</option>
                            </select>
                        </div>
                        <div class="form-group">
                            <label for="phone-storage">Storage</label>
                            <select id="phone-storage" required>
                                <option value="">Select Storage</option>
                                <option value="32GB">32GB</option>
                                <option value="64GB">64GB</option>
                                <option value="128GB">128GB</option>
                                <option value="256GB">256GB</option>
                                <option value="512GB">512GB</option>
                                <option value="1TB">1TB</option>
                            </select>
                        </div>
                        <div class="form-group">
                            <label for="phone-price">Your Asking Price ($)</label>
                            <input type="number" id="phone-price" required placeholder="Enter price in dollars">
                        </div>
                        <div class="form-group">
                            <label for="phone-description">Description</label>
                            <textarea id="phone-description" rows="4" placeholder="Describe any issues, accessories included, etc."></textarea>
                        </div>
                        <div class="form-group">
                            <label for="phone-images">Upload Photos (Max 5)</label>
                            <input type="file" id="phone-images" accept="image/*" multiple>
                            <div class="image-preview" id="image-preview"></div>
                        </div>
                        <button type="submit" class="btn primary">Submit Listing</button>
                    </form>
                    <div class="sell-info">
                        <h3>Why Sell With Us?</h3>
                        <ul>
                            <li><i class="fas fa-check-circle"></i> Get the best price for your used phone</li>
                            <li><i class="fas fa-check-circle"></i> Fast and secure payment</li>
                            <li><i class="fas fa-check-circle"></i> Millions of potential buyers</li>
                            <li><i class="fas fa-check-circle"></i> Free shipping label provided</li>
                            <li><i class="fas fa-check-circle"></i> 24/7 customer support</li>
                        </ul>
                        <div class="price-estimate">
                            <h4>Get an Instant Estimate</h4>
                            <p>Tell us about your phone and we'll give you an estimated value range.</p>
                            <button id="estimate-btn" class="btn secondary">Get Estimate</button>
                        </div>
                    </div>
                </div>
            </div>
        </section>

        <section id="about" class="about-section">
            <div class="container">
                <h2>About MobileBazaar</h2>
                <div class="about-content">
                    <div class="about-text">
                        <p>MobileBazaar is the leading marketplace for buying and selling used smartphones. Our mission is to make mobile technology accessible to everyone by providing a trusted platform for transactions.</p>
                        <p>Founded in 2023, we've helped over 50,000 customers buy and sell their devices with complete peace of mind. All phones listed on our platform go through a verification process to ensure quality and authenticity.</p>
                        <div class="stats">
                            <div class="stat-item">
                                <h3>50,000+</h3>
                                <p>Happy Customers</p>
                            </div>
                            <div class="stat-item">
                                <h3>$5M+</h3>
                                <p>In Transactions</p>
                            </div>
                            <div class="stat-item">
                                <h3>4.8/5</h3>
                                <p>Customer Rating</p>
                            </div>
                        </div>
                    </div>
                    <div class="about-image">
                        <img src="https://via.placeholder.com/400x300" alt="About MobileBazaar">
                    </div>
                </div>
            </div>
        </section>

        <section id="contact" class="contact-section">
            <div class="container">
                <h2>Contact Us</h2>
                <div class="contact-content">
                    <form id="contact-form">
                        <div class="form-group">
                            <label for="contact-name">Name</label>
                            <input type="text" id="contact-name" required>
                        </div>
                        <div class="form-group">
                            <label for="contact-email">Email</label>
                            <input type="email" id="contact-email" required>
                        </div>
                        <div class="form-group">
                            <label for="contact-subject">Subject</label>
                            <input type="text" id="contact-subject" required>
                        </div>
                        <div class="form-group">
                            <label for="contact-message">Message</label>
                            <textarea id="contact-message" rows="5" required></textarea>
                        </div>
                        <button type="submit" class="btn primary">Send Message</button>
                    </form>
                    <div class="contact-info">
                        <h3>Get In Touch</h3>
                        <p><i class="fas fa-envelope"></i> support@mobilebazaar.com</p>
                        <p><i class="fas fa-phone"></i> +1 (555) 123-4567</p>
                        <p><i class="fas fa-map-marker-alt"></i> 123 Tech Street, Silicon Valley, CA 94025</p>
                        <div class="social-links">
                            <a href="#"><i class="fab fa-facebook"></i></a>
                            <a href="#"><i class="fab fa-twitter"></i></a>
                            <a href="#"><i class="fab fa-instagram"></i></a>
                            <a href="#"><i class="fab fa-linkedin"></i></a>
                        </div>
                        <div class="business-hours">
                            <h4>Business Hours</h4>
                            <p>Monday - Friday: 9AM - 6PM</p>
                            <p>Saturday: 10AM - 4PM</p>
                            <p>Sunday: Closed</p>
                        </div>
                    </div>
                </div>
            </div>
        </section>
    </main>

    <footer>
        <div class="container">
            <div class="footer-content">
                <div class="footer-section">
                    <h3>MobileBazaar</h3>
                    <p>The trusted marketplace for buying and selling used smartphones at great prices.</p>
                </div>
                <div class="footer-section">
                    <h3>Quick Links</h3>
                    <ul>
                        <li><a href="#home">Home</a></li>
                        <li><a href="#buy">Buy Phones</a></li>
                        <li><a href="#sell">Sell Phone</a></li>
                        <li><a href="#about">About Us</a></li>
                        <li><a href="#contact">Contact</a></li>
                    </ul>
                </div>
                <div class="footer-section">
                    <h3>Customer Service</h3>
                    <ul>
                        <li><a href="#">FAQ</a></li>
                        <li><a href="#">Shipping Policy</a></li>
                        <li><a href="#">Return Policy</a></li>
                        <li><a href="#">Privacy Policy</a></li>
                        <li><a href="#">Terms of Service</a></li>
                    </ul>
                </div>
                <div class="footer-section">
                    <h3>Newsletter</h3>
                    <p>Subscribe to get updates on new listings and special offers.</p>
                    <form id="newsletter-form">
                        <input type="email" placeholder="Your email address" required>
                        <button type="submit" class="btn primary">Subscribe</button>
                    </form>
                </div>
            </div>
            <div class="footer-bottom">
                <p>&copy; 2023 MobileBazaar. All rights reserved.</p>
            </div>
        </div>
    </footer>

    <!-- Modal for login/register -->
    <div id="auth-modal" class="modal">
        <div class="modal-content">
            <span class="close-modal">&times;</span>
            <div class="auth-tabs">
                <button class="tab-btn active" data-tab="login">Login</button>
                <button class="tab-btn" data-tab="register">Register</button>
            </div>
            <div id="login" class="auth-form active">
                <h3>Login to Your Account</h3>
                <form id="login-form">
                    <div class="form-group">
                        <label for="login-email">Email</label>
                        <input type="email" id="login-email" required>
                    </div>
                    <div class="form-group">
                        <label for="login-password">Password</label>
                        <input type="password" id="login-password" required>
                    </div>
                    <button type="submit" class="btn primary">Login</button>
                    <p class="auth-alternative">Don't have an account? <a href="#" class="switch-tab" data-tab="register">Register</a></p>
                </form>
            </div>
            <div id="register" class="auth-form">
                <h3>Create an Account</h3>
                <form id="register-form">
                    <div class="form-group">
                        <label for="register-name">Full Name</label>
                        <input type="text" id="register-name" required>
                    </div>
                    <div class="form-group">
                        <label for="register-email">Email</label>
                        <input type="email" id="register-email" required>
                    </div>
                    <div class="form-group">
                        <label for="register-password">Password</label>
                        <input type="password" id="register-password" required>
                    </div>
                    <div class="form-group">
                        <label for="register-confirm">Confirm Password</label>
                        <input type="password" id="register-confirm" required>
                    </div>
                    <button type="submit" class="btn primary">Register</button>
                    <p class="auth-alternative">Already have an account? <a href="#" class="switch-tab" data-tab="login">Login</a></p>
                </form>
            </div>
        </div>
    </div>

    <!-- Modal for phone details -->
    <div id="phone-modal" class="modal">
        <div class="modal-content phone-modal-content">
            <span class="close-modal">&times;</span>
            <div id="phone-modal-content">
                <!-- Phone details will be dynamically added here -->
            </div>
        </div>
    </div>

    <script src="script.js"></script>
    document.addEventListener('DOMContentLoaded', function() {
    // Sample phone data
    const phones = [
        {
            id: 1,
            brand: 'Apple',
            model: 'iPhone 12 Pro',
            price: 599,
            condition: 'Good',
            storage: '128GB',
            description: 'iPhone 12 Pro in good condition with minor scratches on the back. Screen is perfect. Comes with original box and charger.',
            images: [
                'https://via.placeholder.com/400x300?text=iPhone+12+Pro+1',
                'https://via.placeholder.com/400x300?text=iPhone+12+Pro+2',
                'https://via.placeholder.com/400x300?text=iPhone+12+Pro+3'
            ]
        },
        {
            id: 2,
            brand: 'Samsung',
            model: 'Galaxy S21 Ultra',
            price: 699,
            condition: 'Like New',
            storage: '256GB',
            description: 'Like new Samsung Galaxy S21 Ultra. Used for only 2 months. Includes all original accessories and box.',
            images: [
                'https://via.placeholder.com/400x300?text=Galaxy+S21+Ultra+1',
                'https://via.placeholder.com/400x300?text=Galaxy+S21+Ultra+2'
            ]
        },
        {
            id: 3,
            brand: 'OnePlus',
            model: '9 Pro',
            price: 449,
            condition: 'Fair',
            storage: '128GB',
            description: 'OnePlus 9 Pro in fair condition. Screen has minor scratches but works perfectly. Comes with case and charger.',
            images: [
                'https://via.placeholder.com/400x300?text=OnePlus+9+Pro+1',
                'https://via.placeholder.com/400x300?text=OnePlus+9+Pro+2',
                'https://via.placeholder.com/400x300?text=OnePlus+9+Pro+3'
            ]
        },
        {
            id: 4,
            brand: 'Google',
            model: 'Pixel 6',
            price: 349,
            condition: 'Good',
            storage: '128GB',
            description: 'Google Pixel 6 in good condition. No scratches on screen, minor wear on edges. Includes original charger.',
            images: [
                'https://via.placeholder.com/400x300?text=Pixel+6+1',
                'https://via.placeholder.com/400x300?text=Pixel+6+2'
            ]
        },
        {
            id: 5,
            brand: 'Apple',
            model: 'iPhone 11',
            price: 299,
            condition: 'Fair',
            storage: '64GB',
            description: 'iPhone 11 in fair condition. Screen has a small crack in the corner but touch works perfectly. Battery health 85%.',
            images: [
                'https://via.placeholder.com/400x300?text=iPhone+11+1',
                'https://via.placeholder.com/400x300?text=iPhone+11+2'
            ]
        },
        {
            id: 6,
            brand: 'Xiaomi',
            model: 'Mi 11 Lite',
            price: 199,
            condition: 'Like New',
            storage: '128GB',
            description: 'Xiaomi Mi 11 Lite like new condition. Used for only 3 weeks. Comes with original box and accessories.',
            images: [
                'https://via.placeholder.com/400x300?text=Mi+11+Lite+1',
                'https://via.placeholder.com/400x300?text=Mi+11+Lite+2',
                'https://via.placeholder.com/400x300?text=Mi+11+Lite+3'
            ]
        }
    ];

    // DOM Elements
    const phoneListings = document.getElementById('phone-listings');
    const sellForm = document.getElementById('sell-form');
    const contactForm = document.getElementById('contact-form');
    const loginForm = document.getElementById('login-form');
    const registerForm = document.getElementById('register-form');
    const newsletterForm = document.getElementById('newsletter-form');
    const authModal = document.getElementById('auth-modal');
    const phoneModal = document.getElementById('phone-modal');
    const loginBtn = document.getElementById('login-btn');
    const registerBtn = document.getElementById('register-btn');
    const applyFiltersBtn = document.getElementById('apply-filters');
    const estimateBtn = document.getElementById('estimate-btn');
    const imagePreview = document.getElementById('image-preview');
    const phoneImagesInput = document.getElementById('phone-images');

    // Display phone listings
    function displayPhones(phonesToDisplay) {
        phoneListings.innerHTML = '';
        
        phonesToDisplay.forEach(phone => {
            const phoneCard = document.createElement('div');
            phoneCard.className = 'phone-card';
            phoneCard.innerHTML = `
                <img src="${phone.images[0]}" alt="${phone.brand} ${phone.model}">
                <div class="phone-info">
                    <h3>${phone.brand} ${phone.model}</h3>
                    <div class="price">$${phone.price}</div>
                    <div class="details">
                        <span>${phone.storage}</span>
                        <span>${phone.condition}</span>
                    </div>
                    <button class="view-btn" data-id="${phone.id}">View Details</button>
                </div>
            `;
            phoneListings.appendChild(phoneCard);
        });

        // Add event listeners to view buttons
        document.querySelectorAll('.view-btn').forEach(btn => {
            btn.addEventListener('click', function() {
                const phoneId = parseInt(this.getAttribute('data-id'));
                const phone = phones.find(p => p.id === phoneId);
                showPhoneModal(phone);
            });
        });
    }

    // Show phone details modal
    function showPhoneModal(phone) {
        const phoneModalContent = document.getElementById('phone-modal-content');
        phoneModalContent.innerHTML = `
            <div class="phone-details">
                <div class="phone-images">
                    ${phone.images.map(img => `<img src="${img}" alt="${phone.brand} ${phone.model}">`).join('')}
                </div>
                <h2>${phone.brand} ${phone.model}</h2>
                <div class="price">$${phone.price}</div>
                <div class="specs">
                    <div class="spec-item">
                        <strong>Brand:</strong>
                        <span>${phone.brand}</span>
                    </div>
                    <div class="spec-item">
                        <strong>Model:</strong>
                        <span>${phone.model}</span>
                    </div>
                    <div class="spec-item">
                        <strong>Storage:</strong>
                        <span>${phone.storage}</span>
                    </div>
                    <div class="spec-item">
                        <strong>Condition:</strong>
                        <span>${phone.condition}</span>
                    </div>
                </div>
                <div class="description">
                    <h4>Description</h4>
                    <p>${phone.description}</p>
                </div>
                <div class="actions">
                    <button class="btn primary">Contact Seller</button>
                    <button class="btn secondary">Make Offer</button>
                </div>
            </div>
        `;
        phoneModal.style.display = 'block';
    }

    // Filter phones
    function filterPhones() {
        const brandFilter = document.getElementById('brand-filter').value;
        const priceFilter = document.getElementById('price-filter').value;
        const conditionFilter = document.getElementById('condition-filter').value;
        
        let filteredPhones = [...phones];
        
        if (brandFilter) {
            filteredPhones = filteredPhones.filter(phone => phone.brand === brandFilter);
        }
        
        if (priceFilter) {
            const [min, max] = priceFilter.split('-').map(Number);
            filteredPhones = filteredPhones.filter(phone => {
                if (max) {
                    return phone.price >= min && phone.price <= max;
                } else {
                    return phone.price >= min;
                }
            });
        }
        
        if (conditionFilter) {
            filteredPhones = filteredPhones.filter(phone => phone.condition === conditionFilter);
        }
        
        displayPhones(filteredPhones);
    }

    // Show auth modal
    function showAuthModal(tab = 'login') {
        authModal.style.display = 'block';
        switchTab(tab);
    }

    // Switch between login and register tabs
    function switchTab(tab) {
        document.querySelectorAll('.auth-form').forEach(form => {
            form.classList.remove('active');
        });
        document.querySelectorAll('.tab-btn').forEach(btn => {
            btn.classList.remove('active');
        });
        
        document.getElementById(tab).classList.add('active');
        document.querySelector(`.tab-btn[data-tab="${tab}"]`).classList.add('active');
    }

    // Close modal
    function closeModal() {
        authModal.style.display = 'none';
        phoneModal.style.display = 'none';
    }

    // Preview images before upload
    phoneImagesInput.addEventListener('change', function() {
        imagePreview.innerHTML = '';
        const files = this.files;
        
        for (let i = 0; i < Math.min(files.length, 5); i++) {
            const file = files[i];
            const reader = new FileReader();
            
            reader.onload = function(e) {
                const img = document.createElement('img');
                img.src = e.target.result;
                imagePreview.appendChild(img);
            }
            
            reader.readAsDataURL(file);
        }
    });

    // Event Listeners
    loginBtn.addEventListener('click', () => showAuthModal('login'));
    registerBtn.addEventListener('click', () => showAuthModal('register'));
    applyFiltersBtn.addEventListener('click', filterPhones);
    estimateBtn.addEventListener('click', () => {
        alert('Price estimation feature coming soon!');
    });

    // Close modal when clicking on X
    document.querySelectorAll('.close-modal').forEach(btn => {
        btn.addEventListener('click', closeModal);
    });

    // Close modal when clicking outside
    window.addEventListener('click', function(event) {
        if (event.target === authModal || event.target === phoneModal) {
            closeModal();
        }
    });

    // Switch tabs in auth modal
    document.querySelectorAll('.switch-tab').forEach(link => {
        link.addEventListener('click', function(e) {
            e.preventDefault();
            const tab = this.getAttribute('data-tab');
            switchTab(tab);
        });
    });

    // Form submissions
    sellForm.addEventListener('submit', function(e) {
        e.preventDefault();
        alert('Your phone listing has been submitted successfully!');
        this.reset();
        imagePreview.innerHTML = '';
    });

    contactForm.addEventListener('submit', function(e) {
        e.preventDefault();
        alert('Your message has been sent successfully!');
        this.reset();
    });

    loginForm.addEventListener('submit', function(e) {
        e.preventDefault();
        alert('Login functionality will be implemented in the backend.');
        this.reset();
        closeModal();
    });

    registerForm.addEventListener('submit', function(e) {
        e.preventDefault();
        alert('Registration functionality will be implemented in the backend.');
        this.reset();
        closeModal();
    });

    newsletterForm.addEventListener('submit', function(e) {
        e.preventDefault();
        alert('Thanks for subscribing to our newsletter!');
        this.reset();
    });

    // Smooth scrolling for navigation
    document.querySelectorAll('nav a').forEach(anchor => {
        anchor.addEventListener('click', function(e) {
            e.preventDefault();
            const targetId = this.getAttribute('href');
            const targetElement = document.querySelector(targetId);
            
            window.scrollTo({
                top: targetElement.offsetTop - 80,
                behavior: 'smooth'
            });
        });
    });

    // Initialize the page
    displayPhones(phones);
});
</body>
</html>
