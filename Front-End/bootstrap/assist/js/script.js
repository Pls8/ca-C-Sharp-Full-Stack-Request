// Enhanced button interactions
        document.addEventListener('DOMContentLoaded', function() {
            // Get all buttons
            const buttons = document.querySelectorAll('.btn');
            const viewWorkBtn = document.getElementById('viewWork');
            const contactMeBtn = document.getElementById('contactMe');
            const downloadResumeBtn = document.getElementById('downloadResume');
            
            // Add click effects to all buttons
            buttons.forEach(button => {
                button.addEventListener('click', function(e) {
                    // Add active class for visual feedback
                    this.classList.add('active');
                    
                    // Remove active class after animation
                    setTimeout(() => {
                        this.classList.remove('active');
                    }, 300);
                    
                    // For anchor links, ensure smooth scrolling works
                    if (this.getAttribute('href') && this.getAttribute('href').startsWith('#')) {
                        e.preventDefault();
                        const targetId = this.getAttribute('href').substring(1);
                        const targetElement = document.getElementById(targetId);
                        
                        if (targetElement) {
                            targetElement.scrollIntoView({
                                behavior: 'smooth',
                                block: 'start'
                            });
                        }
                    }
                });
                
                // Enhanced hover effects
                button.addEventListener('mouseenter', function() {
                    this.style.transform = 'translateY(-3px)';
                    this.style.boxShadow = '0 15px 30px rgba(255, 255, 255, 0.15)';
                });
                
                button.addEventListener('mouseleave', function() {
                    this.style.transform = 'translateY(0)';
                    this.style.boxShadow = 'none';
                });
            });
            
            // Specific button functionality
            if (downloadResumeBtn) {
                downloadResumeBtn.addEventListener('click', function(e) {
                    e.preventDefault();
                    // Simulate download action
                    alert('Resume download would start here!');
                    // In a real scenario, you would link to a PDF file
                    // window.open('path/to/resume.pdf', '_blank');
                });
            }
            
            // Add scroll-based animations
            const observerOptions = {
                threshold: 0.1,
                rootMargin: '0px 0px -50px 0px'
            };
            
            const observer = new IntersectionObserver((entries) => {
                entries.forEach(entry => {
                    if (entry.isIntersecting) {
                        entry.target.style.opacity = '1';
                        entry.target.style.transform = 'translateY(0)';
                    }
                });
            }, observerOptions);
            
            // Observe elements for scroll animations
            const animatedElements = document.querySelectorAll('.animate-fade-in');
            animatedElements.forEach(el => {
                el.style.opacity = '0';
                el.style.transform = 'translateY(30px)';
                el.style.transition = 'opacity 0.6s ease, transform 0.6s ease';
                observer.observe(el);
            });
        });