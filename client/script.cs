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