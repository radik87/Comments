<template>
  <div id="app">
    <div class="comments-outside">
      <div class="comments-header">
        <div class="comments-stats">
          <span><i class="fa fa-comment"></i> {{ comments.length }}</span>
        </div>
        <h4>COMMENTS</h4>
      </div>
      <comments
        :comments_wrapper_classes="['custom-scrollbar', 'comments-wrapper']"
        :comments="comments"
        @submit-comment="submitComment"
      ></comments>
    </div>
  </div>
</template>

<script>
import Comments from "./components/Comments.vue";
import { endpoint } from "./services/apiRouteService";

export default {
  name: "app",
  components: {
    Comments,
  },
  data() {
    return {
      current_dateTime: {
        date: new Date(),
      },
      comments: [],
    };
  },
  methods: {
    submitComment(reply) {
      fetch(endpoint)
        .then((response) => response.json())
        .then((json) => {
          this.comments.push({
            date: this.current_dateTime,
            text: reply,
          });
          this.comments = json;
        })
        .catch((err) => console.log("Request Failed", err));
    },
  },

  created() {
    fetch(endpoint)
      .then((response) => response.json())
      .then((json) => {
        this.comments = json;
      })
      .catch((err) => console.log("Request Failed", err));
  },
};
</script>

<style>
#app {
  font-family: Tahoma, Helvetica, Arial;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}

h4 {
  text-align: right;
}

hr {
  display: block;
  height: 1px;
  border: 0;
  border-top: 1px solid #ececec;
  margin: 1em 0;
  padding: 0;
}

.comments-outside {
  box-shadow: 2px 2px 8px rgba(0, 0, 0, 0.3);
  margin: 0 auto;
  max-width: 1200px;
}

.comments-header {
  background-color: #c8c8c8;
  padding: 10px;
  align-items: center;
  display: flex;
  justify-content: space-between;
  color: #333;
  min-height: 80px;
  font-size: 20px;
}

.comments-header .comments-stats span {
  margin-left: 10px;
}
</style>
