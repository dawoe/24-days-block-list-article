module.exports = {
  mode : 'jit',
  purge: {    
    content: ['../24Days.Web/Views/**/*.cshtml'],
    safelist: []
  },
  darkMode: false, // or 'media' or 'class'
  theme: {
    extend: {      
    },
  },
  variants: {
    extend: {},
  },
  plugins: [    
  ],
}
