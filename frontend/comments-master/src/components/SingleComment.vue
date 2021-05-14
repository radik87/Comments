<template>
  <div class="comment">
    <div class="text">
      <span><b>{{ moment(comment.createdDate) }}: </b>{{ comment.title }}</span>
           
    </div>
  </div>
</template>

<script>
import moment from "moment";

export default {
  name: "singleComment",
  props: ["comment"],

  methods: {
    moment(date) {
      return moment(date).format("DD.MM.YYYY");
    },
  },
};
</script>

<style scoped>
/* Single-comment component */
.comment {
  display: flex;
  padding: 10px;
  margin: 15px 0;
  align-items: center;
  color: #333;
  background-color: #f2f2f2;
  border-radius: 30px;
  box-shadow: 1px 1px 3px rgba(0, 0, 0, 0.2);
}

.comment .text {
  display: flex;
  text-align: left;
  margin-left: 5px;
}

.comment .text span {
  margin-left: 5px;
}
</style>
