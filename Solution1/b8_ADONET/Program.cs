using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b8_ADONET
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * tham khảo : https://yinyangit.wordpress.com/2011/07/31/ado-net-tutorial-lesson-01-introduction-to-ado-net/
             * 
        
            -ADO.NET là một bộ các thư viện hướng đối tượng (OOP) cho phép bạn tương tác với dữ liệu nguồn
             
            -SqlConnection : Để tương tác với database, bạn phải có một kết nối tới nó. Kết nối giúp xác định database server, database name, user name, password, và 
                 các tham số cần thiết để kết nối tới database. Một đối tượng connection được dùng bởi đối tượng command vì thế chúng sẽ biết database nào để thực thi lệnh.
             
            -SqlCommand : Quá trình tương tác với database cần phải biết hành động nào bạn muốn xảy ra. Điều này được thực hiện bởi đối tượng command. Bạn dùng đối tượng
            command để gửi một câu lệnh SQL tới database. Một đối tượng command dùng một đối tượng connection để xác định database nào sẽ được truy xuất. Bạn có thể dùng 
            một đối tượng command riêng lẻ để thực thi lệnh trực tiếp, hoặc để gắn một tham chiếu của đối tượng command cho một SqlDataAdapter
            
            -SqlDataReader : Đối tượng data reader cho phép bạn lấy được kết quả của một câu lệnh SELECT từ một đối tượng command. Để tăng hiệu suất, dữ liệu trả về từ 
             một data reader là một luồng dữ liệu fast forward-only. Có nghĩa là bạn chỉ có thể lấy dữ liệu từ luồng theo một thứ tự nhất định. Mặc dù điều này
               có lợi về mặt tốc độ, nhưng nếu bạn cần phải thao tác dữ liệu, thì một DataSet sẽ là một đối tượng tốt hơn để làm việc
             
            -DataSet : Đối tượng DataSet là một thể hiện của dữ liệu trong bộ nhớ. Chúng chứa nhiều đối tượng DataTable, bên trong DataTable lại có nhiều column và row, giống
                như các database table thông thường. Bạn thậm chí có thể định nghĩa dữ liệu giữa các table để tạo các quan hệ parent-child. DataSet được thiết kế đặc biệt để giúp quản
                lý dữ liệu trong bộ nhớ và để hỗ trợ các thao tác không cần kết nối (disconnected) trên dữ liệu. DataSet là một đối tượng được dùng bởi tất cả Data Provider, đó là lý do 
                tại sao nó không có một Data Provider prefix trong tên gọi
            
            -SqlDataAdapter : 
               + Đôi lúc dữ liệu mà bạn làm việc là read-only và bạn ít khi cần thay đổi dữ liệu nguồn. Vài trường hợp cần lưu trữ tạm dữ liệu trong bộ nhớ để hạn chế truy xuất đến database. 
               Data adapter làm điều này dễ dàng bằng cách giúp bạn quản lý dữ liệu trong chế độ ngắt kết nối. Data adapter sẽ đổ vào DataSet khi đọc dữ liệu và thực hiện thay đổi dữ liệu một lượt vào database.

              +Data adapter chứa một tham chiếu đến đối tượng connection và mở/đóng kết nối tự động khi đọc và ghi dữ liệu vào database. Hơn nữa, data adapter chứa đối tượng command cho những thao tác 
              SELECT, INSERT, UPDATE và DELETE trên dữ liệu. Bạn sẽ có một data adapter được định nghĩa cho mỗi table trong một DataSet và nó sẽ quản lý các giao tiếp với database cho bạn. Tất cả những 
              gì bạn cần làm là chỉ cho data adapter khi nào nạp hoặc ghi vào database.
            */


           
        }
    }
    class DataProviderEx
    {
        /*
         1.Các đối tượng trong DataProvider

            * Đối tượng connection
             - cú pháp : SqlConnection<đối tượng> = new SqlConnection();
                       SqlConnection<đối tượng> = new SqlConnection(<chuỗi kết nối>);

             - ConnectionString : chuỗi kết nối ,State : trạng thái kết nối,Open() mở kết nối ,Close() đóng kết nối              

            * đối tượng command
                - cú pháp : SqlCommand<đối tượng> = new SqlCommand();
                       SqlCommand<đối tượng> = new SqlCommand(<câu lệnh sql>,<đói tượng connection>);
                -
                   + CommandText : câu lệnh SQL ,Connection : đối tượng connection

                   + ExcuteNonQuery() : thực thi truy vấn nhưng không trả về kết quả( ví dụ như insert into)
                   + ExcuteScalar() : trả về giá trị duy nhất (ví dụ select,select top)
                   + ExcuteReader() : trả về 1 đối tượng DataReader
                   + ExcuteXMLReader() : trả về tập tin XML

            * Đối tượng DataReader
              -khai báo : SqlDataReader<đối tượng> = <đối tượng command>.ExcuteReader();
              -
               + FieldCount : cho biết số cột
               + HasRow : trả về true(bản ghi có dữ liệu) hoặc False (Bản ghi không có dữ liệu)
               + IsClose : trả về true(đối tượng dataReader bị đóng không đọc được dữ liệu) hoặc ngược lại false

               + Read() : True đọc được 1 dòng dữ liệu và con trỏ sẽ trỏ đến dòng kế tiếp, false đọc hết dữ liệu
               + GetString() : Lấy giá trị của một cột, trả về kiểu string
               + GetInt32() : Lấy giá trị của một cột, trả về kiểu int.
               + GetInt64(): Lấy giá trị của một cột, trả về kiểu long
               + GetByte() : Lấy giá trị của một cột có kiểu byte

            * đối tượng Data Adapter
              -cú pháp : SqlDataAdapter< đối tượng > =  new SqlDataAdapter();
                         SqlDataAdapter< đối tượng > =  new SqlDataAdapter( <câu lệnh> , <chuỗi kết nối>);
              - 
                + SelectCommand : đối tượng command dùng để truy vấn dữ liệu
                + DeleteCommand : đối tượng command dùng để xóa dữ liệu
                + InsertCommand : đối tượng command dùng để chèn dữ liệu
                + UpdateCommand : đối tượng command dùng để cập nhật dữ liệu

                + Update() : Cập nhật dự liệu từ Dataset/DataTable và Datasourse(thêm, xóa, sửa dữ liệu).
                + Fill() : đổ dữ liệu vào data table
            */
    }

    class DataSetEx
    {
        /*
         * đối tượng DataSet
          - cú pháp : DataSet < đối tượng > =  new DataSet();
                      DataSet < đối tượng > =  new DataSet( <tên DataSet>);
          - 
            + DataSetName : Tên DataSet
            + Tables  : Trả về danh sách các datatable trong DataSet.
            + Relations  : Mối quan hệ giữa các datatable trong DataSet.
            
            + AcceptChanges() : Chấp nhận thay đổi trên DataSet
            + Clear() : Loại bỏ tất cả đối tượng DataTable trong DataSet.
            + RejectChanges() : Hủy bỏ mọi sự thay đổi

         * đối tượng data table
           - cú pháp : DataTable < đối tượng > =  new DataTable ();
                       DataTable < đối tượng > =  new DataTable ( <tên DataTable >);

           - 
             + TableName : tên DataTable
             + DataSet : DataSet chứa DataTable
             + Rows : Dòng
             + Columns : Cột

             + AcceptChanges() : Chấp nhận thay đổi trên DataTable
             + RejectChange() : Hủy mọi sự thay đỏi
             + NewRow() : tạo ra 1 dòng (DataRow)
             + Load() : Load dữ liệu từ DataReader
          * đối tượng Data View
            - khởi tạo : DataView < đối tượng > =  new DataView ();
                         DataView < đối tượng > =  new DataView (<đối tượng DataTable>);
            - 
              + count : số dòng trên DataView
              + Sort : biểu thức sắp xếp
              + RowFiller : Lọc các dòng trên dữ liệu trên DataView
              + Table : trả về bản Table gốc

              + Find(object) : trả về nhiều dòng
              + FindRow(object) : trả về 1 dòng thỏa mãn object
              + AddNew() : Thêm 1 DataRowView vào DataView
              + Delete() : Xóa DataRowView khỏi DataView theo chỉ số


         */
    }
}
