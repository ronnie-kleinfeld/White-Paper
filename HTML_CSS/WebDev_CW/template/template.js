function showSidebar(){
    const sidebar = document.querySelector('.sidebar')
    // This will change the display of the sidebar from "none" to "flex". Which will make the sidebar appears when the menu button is clicked.
    sidebar.style.display = 'flex'
  }
  function hideSidebar(){
    const sidebar = document.querySelector('.sidebar')
    // This will change the display of the sidebar from "flex" to "none". Which will make the sidebar disappears when the close button is clicked.
    sidebar.style.display = 'none'
  }

  // Function to close sidebar when window is resized to desktop view
  function closeSidebarOnResize() {
    const sidebar = document.querySelector('.sidebar');
    const screenWidth = window.innerWidth;

    if (screenWidth > 800) {
      hideSidebar();
    }
  }

  // Add event listener for window resize event
  window.addEventListener('resize', closeSidebarOnResize);