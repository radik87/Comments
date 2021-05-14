import moment from "moment";

class DateFormatter {
  getFormatedDate(date) {
    return moment(date).format("DD.MM.YYYY");
  }
}
export default new DateFormatter();
