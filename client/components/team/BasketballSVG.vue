<template>
  <div>
    <svg :width="width" :height="height" xmlns="http://www.w3.org/2000/svg">
      <!-- Basketball shape (circle) -->
      <circle :cx="circleCX" :cy="circleCY" :r="circleRadius" :fill="circleFill" />
      
      <!-- Black lines on the basketball -->
      <line x1="20" y1="100" x2="180" y2="100" stroke="black" stroke-width="5" />
      <line x1="100" y1="20" x2="100" y2="180" stroke="black" stroke-width="5" />

      <!-- Text element for the year -->
      <text :x="textX" :y="textY" dominant-baseline="middle" text-anchor="middle" :font-size="textFontSize" :fill="textFill">
        {{ year }}
      </text>
    </svg>
  </div>
</template>

<script>
export default {
  props: {
    year: {
      type: Number,
      required: true,
    },
    width: {
      type: Number,
      default: 200,
    },
    height: {
      type: Number,
      default: 200,
    },
    circleCX: {
      type: Number,
      default: 100,
    },
    circleCY: {
      type: Number,
      default: 100,
    },
    circleRadius: {
      type: Number,
      default: 80,
    },
    circleFill: {
      type: String,
      default: '#FFA500', // Orange color
    },
    textX: {
      type: String,
      default: '50%',
    },
    textY: {
      type: String,
      default: '50%',
    },
    textFontSize: {
      type: Number,
      default: 24,
    },
    textFill: {
      type: String,
      default: '#ffffff', // White color
    },
  },
};
</script>
